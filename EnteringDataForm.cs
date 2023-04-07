using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Convert;

namespace Курсовая_АСОИР191_Ткачёв_С.А
{
    public partial class EnteringDataForm : Form
    {
        const string file = @"database_file.txt";
        String [ ] massivStr;

        LoginForm login_form = new LoginForm();//
        public EnteringDataForm ( )
        {
            InitializeComponent ();
            Date_box.Text = "5";
            DateAcceptance_box.Text = DateTime.Now.ToShortDateString();
            
        }
        
        private void EnteringDataForm_Load ( object sender , EventArgs e )
        {

        }

        private void label1_Click ( object sender , EventArgs e )
        {
            Application.Exit ();
        }


        private void GoTo_Authorization_Button_Click ( object sender , EventArgs e )
        {
            this.Hide ();
            login_form.Show ();
        }

        private void SaveDataBase_Button_Click ( object sender , EventArgs e )
        {
            string Date = Date_box.Text;
            int temp;
            massivStr = Reader ();
            int number;
            
            number = ToInt32 ( massivStr [ 13 ] ) + 1;

            if (Date_box.Text == null)
                { Date_box.Text = "5"; }
            temp = int.Parse(Date_box.Text);
            Date = DateTime.Now.AddDays(temp).ToShortDateString();
            

            using (var bw = new StreamWriter ( file , true ))
            {

                bw.Write ( "{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}\t\t{6}\t\t{7}\t\t{8}\t\t{9}\t\t{10}\t\t{11}\t\tВ ремонте\t\t{12}\t\tНет данных\t\tНет данных\t\tДата неизвестна\r\n" ,
                    DateAcceptance_box.Text ,
                    Date,
                    Type_box.Text ,
                    ProductBrand_box.Text ,
                    SerialNumber_box.Text ,
                    FCsСlient_masked.Text ,
                    FCsReceiver_masked.Text ,
                    Phone_masked.Text ,
                    WarrantyRepair_check.Checked ,
                    Equipment_box.Text ,
                    Appearance_box.Text ,
                    TechnicalFailures_box.Text,
                    number );
            }
            this.Hide ();
            ReceiverForm receiver_form = new ReceiverForm ();
            receiver_form.Show ();
        }
        public string[] Reader()
        {
            using (var bw = new StreamReader ( file ))
            {
                for ( ; ; )
                {
                    string str = bw.ReadLine ();
                    if (str == null)
                        break;

                    massivStr = str.Split ( new string [ ] { "\t\t" } ,
                        StringSplitOptions.RemoveEmptyEntries );
                }
                return massivStr;
            }
        }
    }
}
