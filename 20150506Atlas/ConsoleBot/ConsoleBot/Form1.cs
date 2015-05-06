using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Bot myBot = new Bot();

        SpeechSynthesizer sSynth = new SpeechSynthesizer(); // speech synthesizer engine robi
        const string UserId = "CityU.Scm.David";
        String temp;
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text.
            textBox2.AppendText("User: " + textBox1.Text + "\n");
            temp = textBox1.Text;
            textBox1.Text = null;
            process(temp.ToString());
            

        }

        public String process(String input_string)
        {

            myBot.loadSettings();

            User myUser = new User(UserId, myBot);
            myBot.isAcceptingUserInput = false;
            myBot.loadAIMLFromFiles();
            myBot.isAcceptingUserInput = true;

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
                Request r = new Request(input, myUser, myBot);
                Result res = myBot.Chat(r);

                //Console.WriteLine("Bot: " + res.Output);
                //robi starts
                textBox2.AppendText("Atlas: "+ res.Output + "\n");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
