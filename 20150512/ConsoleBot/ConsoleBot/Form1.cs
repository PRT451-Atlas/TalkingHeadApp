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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bot myBot;
        User myUser;
        SpeechSynthesizer sSynth = new SpeechSynthesizer(); // speech synthesizer engine robi
        String temp;

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
            Thread clearText = new Thread(new ThreadStart(startTalking));
            Thread botstartTalking = new Thread(new ThreadStart(clearTextbox1));
            textBox2.AppendText("User: " + textBox1.Text + "\n");
            temp = textBox1.Text;
            textBox1.Clear();
            process(temp.ToString());
            //botstartTalking.Start();
            //clearText.Start();
        }
        public void startTalking()
        {
            process(textBox1.ToString());
        }
        public void clearTextbox1()
        {
            textBox1.Clear();
        }

        public String process(String input_string)
        {
            //Console.Write("You: ");
            string input = input_string;
            if (input.ToLower() == "quit")
            {
                //break;
                Application.Exit();
                return null;
            }
            else
            {
                Request r = new Request(input, this.getUser(), this.getBot());
                Result res = myBot.Chat(r);

                //Console.WriteLine("Bot: " + res.Output);
                //robi starts
                textBox2.AppendText("Atlas: " + res.Output + "\n");
                sSynth.Speak(res.Output);
                return res.Output;
                //robi ends
            }
        }

        //private void pictureBox1_Paint(object sender, PaintEventArgs e)
        //{
        //    using (Font myFont = new Font("Arial", 14))
        //    {
        //        e.Graphics.DrawString("Hello .NET Gjbbkbkbkbkbkubkubkubkubkubkuuide!", myFont, Brushes.Green, new Point(2, 2));
        //    }
        //}

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
            Form2 aboutTeam = new Form2();
            aboutTeam.Show();
        }

        private void aboutAIMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 aboutAIML = new Form3();
            aboutAIML.Show();
        }

        private void aboutAtlasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 aboutATLAS = new Form4();
            aboutATLAS.Show();
        }
    }
}
