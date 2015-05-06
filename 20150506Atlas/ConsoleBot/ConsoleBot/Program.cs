using System;
using AIMLbot;
using System.Speech.Synthesis;
using System.Windows.Forms;






namespace ConsoleBot
{
    class Program 
    {
        
        //const string UserId = "CityU.Scm.David";
        static void Main(string[] args)
        {
            
            //[STAThread]
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Form Form1 = new Form();
            Application.Run(new Form1());
            
        }


        
    }
}

