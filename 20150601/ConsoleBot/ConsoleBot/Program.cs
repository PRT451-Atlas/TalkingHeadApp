using System;
using AIMLbot;
using System.Speech.Synthesis;
using System.Windows.Forms;






namespace ConsoleBot
{
    class Program 
    {
        
        static void Main(string[] args)
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TalkingHeadApp());
            
        }


        
    }
}

