using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mycontext());
        }

        public class mycontext : ApplicationContext
        {
            public mycontext()
            {
                Form1 f1 = new Form1();
                Form2 f2 = new Form2(f1);
                f1.Show();
            }
        }
    }
}
