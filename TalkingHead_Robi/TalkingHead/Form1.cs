using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;


namespace TalkingHead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        PromptBuilder pBuilder = new PromptBuilder();
        SpeechRecognitionEngine sRecogEngine = new SpeechRecognitionEngine();
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /*button 1 - speak text*/

        private void button1_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            Image image = Image.FromFile("G:/MSIT/sem 2 - sem 1, 2015/PRT 451 - Principles of software engineering/gif/Yogi_Normal_1.gif");
            pictureBox1.Image = image;
            if (textBox1.Text == "How are you"){
                pBuilder.AppendText("I am good how are you");
            }
            //pBuilder.AppendText(textBox1.Text);
            //pBuilder.AppendText("I am good how are you");
            //pictureBox1.ImageLocation = "G:/MSIT/sem 2 - sem 1, 2015/PRT 451 - Principles of software engineering/gif/img21.gif";
            
            sSynth.Speak(pBuilder);

        }

        /*Button 2 - start*/

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = true;
            Choices sList = new Choices();
            sList.Add(new String[]{"Hello","How","are","you","good","Thank","you","no"});
            Grammar gr = new Grammar(new GrammarBuilder(sList));
            try {
                sRecogEngine.RequestRecognizerUpdate();
                sRecogEngine.LoadGrammar(gr);
                sRecogEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sRecogEngine_SpeechRecognized);
                sRecogEngine.SetInputToDefaultAudioDevice();
                sRecogEngine.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch {
                return;
            }
        }

        void sRecogEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //throw new NotImplementedException();
            //MessageBox.Show("Speech recognized : " + e.Result.Text.ToString());
            //textBox1.Text = textBox1.Text + e.Result.Text;
            if (e.Result.Text == "exit")
            {
                Application.Exit();
            }
            else {
                textBox1.Text = textBox1.Text + " " + e.Result.Text;
            }
        }

        /*Button 3  - Stop*/

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = false;
            sRecogEngine.RecognizeAsyncStop();
        }

    }
}
