using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    static class Program
    {
        // Any method can now access the form
        static Form1 MyForm;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyForm = new Form1();
            Application.Run(MyForm);
        }

    }
}