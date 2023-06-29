using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CapStone
{
    static public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Creates sound class and plays entering sound when form is loaded
            SoundPlayer sp = new SoundPlayer(Environment.CurrentDirectory + @"\sounds\Enter.wav");
            sp.PlaySync();

            Application.Run(new LogInScreen());
                
        }

        
    }

}
