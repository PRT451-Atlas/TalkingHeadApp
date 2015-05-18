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
using AIMLbot;
using System.Speech.Synthesis;

namespace ConsoleBot
{
    public partial class TalkingHeadApp : Form
    {
        public TalkingHeadApp()
        {
            InitializeComponent();
        }

        Bot myBot;
        User myUser;
        SpeechSynthesizer sSynth = new SpeechSynthesizer(); // speech synthesizer engine robi
        String synthesizer;
        String name = "Atlas";
        Boolean flag = true;
        int volumerate = 0;

        public void do_first()
        {
            Bot myBot = new Bot();
            const string UserId = "Team Atlas";
            myBot.loadSettings();
            User myUser = new User(UserId, myBot);
            myBot.isAcceptingUserInput = false;
            myBot.loadAIMLFromFiles();
            myBot.isAcceptingUserInput = true;
            setBot(myBot);
            setUser(myUser);
        }

        public void setBot(Bot x)
        {
            this.myBot = x;
        }

        public Bot getBot()
        {
            return this.myBot;
        }

        public void setUser(User y)
        {
            this.myUser = y;
        }

        public User getUser()
        {
            return this.myUser;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            do_first();
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\picture\\head.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox2.AppendText("User: " + textBox1.Text + "\r\n");
                process(textBox1.Text.ToString());
            }
            textBox1.Clear();
        }

        public void startTalking()
        {
            sSynth.Speak(synthesizer);  // SpeechSynthesizer executing in a different thread instead of the main
        }

        public String process(String input_string)
        {
            string input = input_string;
            if (input.ToLower() == "quit")
            {
                Application.Exit();
                return null;
            }
            else
            {
                    Request r = new Request(input, this.getUser(), this.getBot());
                    Result res = myBot.Chat(r);
                    synthesizer = res.Output;
                    textBox2.AppendText(name.ToString()+": " + res.Output + "\r\n");
                    Thread starttalking = new Thread(startTalking); //creating the new thread
                    starttalking.Start(); // execute the thread
                    return res.Output;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void aboutTheTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutTheTeam aboutTeam = new AboutTheTeam();
            aboutTeam.ShowDialog();
        }

        private void aboutAIMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutAIML aboutAIML = new AboutAIML();
            aboutAIML.ShowDialog();
        }

        private void aboutAtlasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutAtlas aboutATLAS = new AboutAtlas();
            aboutATLAS.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            configurePanel.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to use the default settings?", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sSynth.Volume = 80;
                sSynth.Rate = 0;
                rateBar.Value = 0;
                volumeBar.Value = 80;
            }
        }

        private void configurePanel_MouseMove(object sender, MouseEventArgs e)
        {
            configurePanel.BackColor = System.Drawing.Color.SteelBlue;
        }

        private void configurePanel_MouseLeave(object sender, EventArgs e)
        {
            configurePanel.BackColor = Color.Transparent;
        }

        private void volumeBar_Scroll(object sender, EventArgs e)
        {
            if (volumeBar.Value == 0)
            {
                pictureBox2.BackgroundImage = Image.FromFile("volume_off.png");
            }
            else
            {
                pictureBox2.BackgroundImage = Image.FromFile("volume_on.png");
            }
            sSynth.Volume = volumeBar.Value;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                volumerate = volumeBar.Value;
                volumeBar.Value = 0;
                pictureBox2.BackgroundImage = Image.FromFile("volume_off.png");
                flag = false;
            }
            else if (flag == false)
            {
                volumeBar.Value = volumerate;
                pictureBox2.BackgroundImage = Image.FromFile("volume_on.png");
                flag = true;
            }
        }

        private void rateBar_Scroll(object sender, EventArgs e)
        {
            sSynth.Rate = rateBar.Value;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = System.Drawing.SystemColors.Control;
            button3.ForeColor = System.Drawing.Color.Black;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = System.Drawing.Color.PaleTurquoise;
            button3.ForeColor = System.Drawing.Color.Green; 
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.SystemColors.Control;
            button2.ForeColor = System.Drawing.Color.Black;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = System.Drawing.Color.PaleTurquoise;
            button2.ForeColor = System.Drawing.Color.Green;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.SystemColors.Control;
            button1.ForeColor = System.Drawing.Color.Black;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = System.Drawing.Color.PaleTurquoise;
            button1.ForeColor = System.Drawing.Color.Green;
        }

        private void talkToAtlasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sSynth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
            textBox2.Clear();
            do_first();
            name = "Atlas";
        }

        private void talkToAliceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sSynth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            textBox2.Clear();
            do_first();
            name = "Alice";
        }

        private void configuresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            configurePanel.Visible = true;
        }
    }
}
