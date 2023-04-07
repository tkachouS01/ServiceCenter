using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_АСОИР191_Ткачёв_С.А
{
    static class Program
    {
        static void Main ( )
        {
            Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault ( false );
            Application.Run ( new LoginForm () );
        }
    }
}
