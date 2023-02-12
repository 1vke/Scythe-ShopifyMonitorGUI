using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;


namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, Process> moniPro = new Dictionary<string, Process>();
        List<Process> discProc = new List<Process> { };
        
        string data, strm = null;
        string path,confpath;
        string[] settings;

        string RootFolderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);


        private void Form1_Load(object sender, EventArgs e)
        {
            populateWebs();
            selectAll();
            confpath = RootFolderPath+@"\conf.txt";
            settings = File.ReadAllText(confpath).Split('^');
        }

        private void populateWebs()
        {
            string[] webs = File.ReadAllText(RootFolderPath+@"\websites.txt").Split('\n');

            foreach (string web in webs)
            {
                if (web.Length > 0)
                {
                    pnlWeb.Items.Add(web);
                }
            }
        }
        private void btnBr_Click(object sender, EventArgs e)
        {
            ofd1.Filter = "Python|*.py|Text|*.txt";
            ofd1.DefaultExt = "py";
            ofd1.Title = "Open File...";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                path = ofd1.FileName;
                data = File.ReadAllText(path);
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            btnRun.Enabled = false;
            pnlWeb.Enabled = false;

            try {
                foreach (object itemChecked in pnlWeb.CheckedItems)
                {
                    RunMonitor(itemChecked.ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception caught: " + ex);
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            rtbM.Text = "";
        }

       
 
        public void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Process proc = (Process)sender;
            RichTextBox tb = rtbDisc;
            if (discProc.Contains(proc))
            {
                tb = rtbDisc;
            }
            if (e.Data != "" && e.Data != null)
            rtbM.Invoke((MethodInvoker)(() => tb.Text += e.Data + '\n'));
        }



        private void rtbM_TextChanged(object sender, EventArgs e)
        {
            if (cbAuto.Checked == true) { 
                rtbM.SelectionStart = rtbM.Text.Length;
                rtbM.ScrollToCaret();
            }
        }

        private void btnWebpop_Click(object sender, EventArgs e)
        {
            pnlWeb.Items.Clear();
            populateWebs();
        }

        private void btnWebsel_Click(object sender, EventArgs e)
        {
            selectAll();
        }

        private void selectAll()
        {
            for (int i = 0; i < pnlWeb.Items.Count; i++)
            {
                if (pnlWeb.GetItemChecked(i) == true)
                {
                    pnlWeb.SetItemChecked(i, false);
                }
                else { pnlWeb.SetItemChecked(i, true); }
            }
        }

        private void btnDiscStart_Click(object sender, EventArgs e)
        {
            try { discordStart(); btnDiscStart.Enabled = false; }
            catch(Exception ex) { MessageBox.Show($"Ran into an error whilst starting the discord bot process.\n\n{e}"); }
            
        }

        private async Task discordStart()
        {
            await Task.Run(() =>
            {
                var process = processStart("discbot.py", $"{settings[0]} {settings[1]} {settings[3]} {settings[5]}");

                discProc.Add(process);

                process.BeginErrorReadLine();
                process.BeginOutputReadLine();
                process.WaitForExit();

                discProc.Remove(process);

                if (discProc.Count == 0)
                {
                    btnDiscStart.Enabled = true;
                }
            });
        }
        public async Task RunMonitor(string website)
        {
            await Task.Run(() =>
            {
                var process = processStart("monitemp.py", $"{website} {settings[2]} {settings[4]} {settings[6]}");

                moniPro.Add(website, process);

                process.BeginErrorReadLine();
                process.BeginOutputReadLine();
                process.WaitForExit();

                moniPro.Remove(website);

                if (moniPro.Count == 0)
                {
                    btnRun.Enabled = true;
                    pnlWeb.Enabled = true;
                    pnlWeb.ForeColor = Color.Black;
                }
            });

        }
        private Process processStart(string script, string args)
        {
            // This creates/starts a process and returns it. It starts a certain python
            // script depending on the variable 'script' with the arguments 'args'.

            var cmd = RootFolderPath+script;
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Programs\Python\Python310\python.exe",
                    Arguments = $"{cmd} {args}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                },
                EnableRaisingEvents = true
            };

            process.ErrorDataReceived += Process_OutputDataReceived;
            process.OutputDataReceived += Process_OutputDataReceived;

            process.Start();
            return process;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox tb = (TextBox)sender;
                sendMessage(tb.Text);
                txtMessage.Text = "";
            }
        }
        private async Task sendMessage(string message)
        {
            await Task.Run(() =>
            {
                var process = processStart("sendMessage.py", $"{getChannel()} \"{message}\"");
            });
        }

        private string getChannel()
        {
            List<string> channels = new List<string>(){ settings[1], settings[3], settings[5], txtChannelID.Text};
            return channels[cbDisc.SelectedIndex];
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            sendMessage(txtMessage.Text);
            txtMessage.Text = "";  
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < moniPro.Count; i++)
            {
                moniPro.ElementAt(i).Value.Kill();
                moniPro.Remove(moniPro.ElementAt(i).Key);
            }
            foreach (Process process in discProc.ToList())
            {
                process.Kill();
                discProc.Remove(process);
            }

        }

        private void settingsHelper(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            List<TextBox> tbs = tbSettings.Controls.OfType<TextBox>().ToList();
            settings[tbs.IndexOf(tb)] = tb.Text;

            updConf();
        }

        private void updConf()
        {
            File.WriteAllText(confpath, string.Join("^",settings));
        }


        private void btnDiscClear_Click(object sender, EventArgs e) {rtbDisc.Text = "";}

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tbSettings) { settingsFill(); }
            else if(tabControl1.SelectedTab == tbDisc) { cbDisc.SelectedIndex = 0; }
            else if(tabControl1.SelectedTab == tbMon) {  }
        }
        private void settingsFill()
        {
            List<TextBox> tbs = tbSettings.Controls.OfType<TextBox>().ToList();
            foreach (TextBox tb in tbs)
            {
                tb.Text = settings[tbs.IndexOf(tb)];
            }
        }

        private void txtBotToken_MouseHover(object sender, EventArgs e)
        {
            txtBotToken.BackColor = Color.White;
        }

        private void txtBotToken_MouseLeave(object sender, EventArgs e)
        {
            txtBotToken.BackColor = Color.Black;
        }

        private void btnDiscStop_Click(object sender, EventArgs e)
        {
            foreach (Process process in discProc.ToList())
            {
                process.Kill();
                discProc.Remove(process);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            for(int i = 0;i < moniPro.Count; i++)
            {
                moniPro.ElementAt(i).Value.Kill();
                moniPro.Remove(moniPro.ElementAt(i).Key);
            }

            btnRun.Enabled = true;
            pnlWeb.Enabled = true;
        }

    }
  
}
