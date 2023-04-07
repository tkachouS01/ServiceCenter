using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Курсовая_АСОИР191_Ткачёв_С.А
{
    class DataBase
    {
        const string file = @"database_file.txt";
        public void ChangingBD ( int number , string status , string prise , string doneWork, string dateIssue )
        {
            string temp;
            string [ ] arStr = File.ReadAllLines ( file );//весь файл
            temp = arStr [ number - 1 ];
            String [ ] massiv = temp.Split ( new string [ ] { "\t\t" } ,
        StringSplitOptions.RemoveEmptyEntries ); //теущая строка в массив
            massiv [ 12 ] = status;
            massiv [ 14 ] = prise;
            massiv [ 15 ] = doneWork;
            massiv [ 16 ] = dateIssue;

            arStr [ Convert.ToInt32 ( number ) - 1 ] = null;
            int i;
            for (i = 0 ; i <= 16 ; i++)
            {
                arStr [ number - 1 ] += massiv [ i ];
                if (i != 16)
                    arStr [ number - 1 ] += "\t\t";
            }



            using (var bw = new StreamWriter ( file , false ))
            {
                for (i = 0 ; i < arStr.Length ; i++)
                {
                    bw.WriteLine ( arStr [ i ] );
                }
            }
            MessageBox.Show ( $"Данные о заказе №{number} сохранены!" , "Сохранение заказа" , MessageBoxButtons.OK , MessageBoxIcon.Exclamation );

        }
    }
}
