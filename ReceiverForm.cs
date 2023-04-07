using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Collections;

namespace Курсовая_АСОИР191_Ткачёв_С.А
{
    public partial class ReceiverForm : Form
    {
        LoginForm login_form = new LoginForm ();
        MasterForm master_form = new MasterForm ( );
        const string file = @"database_file.txt";
        public ReceiverForm ( )
        {
            InitializeComponent ();
        }

        private void NewOrder_Click ( object sender , EventArgs e )
        {
            EnteringDataForm entering_data = new EnteringDataForm ();
            this.Hide ();
            entering_data.Show ();
        }

        private void label2_Click ( object sender , EventArgs e )
        {
            Application.Exit ();
        }

        private void GoTo_Authorization_Button_Click ( object sender , EventArgs e )
        {
            this.Hide ();
            login_form.Show ();
        }

        private void TotalRevenue_Click ( object sender , EventArgs e )
        {
            //------------------------КНОПКИ ЦВЕТ
            TotalRevenue_button.BackColor = Color.RoyalBlue;
            IssuingOrder_button.BackColor = Color.Snow;
            ListOrder_button.BackColor = Color.Snow;
            //-------------------------------------
            IssuingOrder_panel.Visible = false;
            TotalRevenue_panel.Visible = true;
            dataGridView.Visible = false;
            
            
        }

        private void IssuingOrder_Click ( object sender , EventArgs e )
        {
            //------------------------КНОПКИ ЦВЕТ
            IssuingOrder_button.BackColor = Color.RoyalBlue;
            TotalRevenue_button.BackColor = Color.Snow;
            ListOrder_button.BackColor = Color.Snow;
            //-------------------------------------
            IssuingOrder_panel.Visible = true;
            dataGridView.Visible = false;
            TotalRevenue_panel.Visible = false;
            

        }

        private void ListOrder_Click ( object sender , EventArgs e )
        {
            this.dataGridView.Location = new System.Drawing.Point ( 0 , 142 );
            this.dataGridView.Size = new System.Drawing.Size ( 1408 , 627 );
            //------------------------КНОПКИ ЦВЕТ
            ListOrder_button.BackColor = Color.RoyalBlue;
            TotalRevenue_button.BackColor = Color.Snow;
            IssuingOrder_button.BackColor = Color.Snow;
            //-------------------------------------
            IssuingOrder_panel.Visible = false;
            TotalRevenue_panel.Visible = false;
            
            
            
            //-------------------------------------
            
            

            
            using (var bw = new StreamReader ( file ))
            {
                while (dataGridView.Rows.Count > 1)
                    dataGridView.Rows.Remove ( dataGridView.Rows [ 0 ] );
                int y;
                for (y = 0 ; ; y++)
                {
                    
                    string str = bw.ReadLine ();
                    if (str == null)
                        break;
                    dataGridView.Rows.Add ();
                    String [ ] massivStr = str.Split ( new string [ ] { "\t\t" } ,
                        StringSplitOptions.RemoveEmptyEntries );

                    if (massivStr [ 12 ] == "Готово")
                    {
                        dataGridView.Rows [ y ].DefaultCellStyle.BackColor = Color.Green;
                        dataGridView.Rows [ y ].DefaultCellStyle.ForeColor = Color.White;
                    }

                    if (massivStr [ 12 ] == "В ремонте")
                    {
                        dataGridView.Rows [ y ].DefaultCellStyle.BackColor = Color.OrangeRed;
                        dataGridView.Rows [ y ].DefaultCellStyle.ForeColor = Color.White;
                    }

                    record ( y , 0 , massivStr [ 13 ] );
                    record ( y , 1 , massivStr [ 5 ] );
                    record ( y , 2 , massivStr [ 7 ] );
                    record ( y , 3 , massivStr [ 12 ] );
                    record ( y , 4 , massivStr [ 14 ] );
                    record ( y , 5 , massivStr [ 0 ] );
                    record ( y , 6 , massivStr [ 1 ] );
                    record ( y , 7 , massivStr [ 2 ] );
                    record ( y , 8 , massivStr [ 3 ] );
                    record ( y , 9 , massivStr [ 4 ] );
                    record ( y , 10 , massivStr [ 8 ] );
                    record ( y , 11 , massivStr [ 11 ] );
                    record ( y , 12 , massivStr [ 15 ] );
                }
                
                dataGridView.Visible = true;
            }
            
        }
        public void record ( int y , int x , string element )
        {
            dataGridView.Rows [ y ].Cells [ x ].Value = Convert.ToString ( element );
        }

        private void Calculate_Click ( object sender , EventArgs e )
        {
            ArrayList ListDate = new ArrayList ();
            ArrayList ListPrise = new ArrayList ();
            while (dataGridView.Rows.Count > 1)
                dataGridView.Rows.Remove ( dataGridView.Rows [ 0 ] );
            
                
            DateTime Date1 = Convert.ToDateTime(date1.Value.ToShortDateString () );
            DateTime Date2 = Convert.ToDateTime ( date2.Value.ToShortDateString () );
            if (Date1 > Date2)
                MessageBox.Show ( $"Указан неверный интервал!" , "Общий доход" , MessageBoxButtons.OK , MessageBoxIcon.Error );
            else
            {
                using (var bw = new StreamReader ( file ))
                {
                    for (int y = 0 ; ; y++)
                    {
                        string str = bw.ReadLine ();
                        if (str == null)
                            break;

                        String [ ] massivStr = str.Split ( new string [ ] { "\t\t" } ,
                            StringSplitOptions.RemoveEmptyEntries );
                        if (massivStr [ 12 ] == "Выдано" &&
                            massivStr [ 8 ] == "False")
                        {
                            ListDate.Add ( massivStr [ 16 ] );
                            ListPrise.Add ( massivStr [ 14 ] );
                        }
                    }

                    if (ListDate.Count == 0)
                        MessageBox.Show ( $"СЦ не выдал ни одного заказа с гарантийным ремонтом!\nНет дохода!" , "Общий доход" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                    else
                    {
                        for (int k = ListDate.Count - 1 ; k >= 0 ; k--)
                        {
                            if (Convert.ToDateTime ( ListDate [ k ] ) < Date1 ||
                                Convert.ToDateTime ( ListDate [ k ] ) > Date2)
                            {

                                ListPrise.RemoveAt ( k );
                            }
                        }
                        int sum = 0;

                        foreach (string element in ListPrise)
                        {
                            sum += Convert.ToInt32 ( element );
                        }

                        if (sum != 0)
                        {
                            TotalRevenue_label.Visible = true;
                            TotalRevenue_box.Text = Convert.ToString ( sum );
                            TotalRevenue_box.Visible = true;
                        }
                        else
                            MessageBox.Show ( $"Выданных заказов на данном интервале с ганантийным ремонтом не найдено!\nНет дохода!" , "Общий доход" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged ( object sender , EventArgs e )
        {

        }

        private void ReceiverForm_Load ( object sender , EventArgs e )
        {
            ListOrder_button.PerformClick ();

        }
        bool add = false;
        private void Retrieval_Click ( object sender , EventArgs e )
        {

            if (add == false)
            {
                dataGridView.Rows.Add ();
            }
            add = true;
            dataGridView.Visible = false;


            dataGridView.Height = 70;
            dataGridView.Location = new Point ( 0 , 317 );


            using (var bw = new StreamReader ( file ))
            {
                for (int y = 0 ; ; y++)
                {
                    string str = bw.ReadLine ();
                    if (str == null)
                    {
                        MessageBox.Show ( $"Заказ не найден!" , "Поиск заказа" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                        break;
                    }

                    String [ ] massivStr = str.Split ( new string [ ] { "\t\t" } ,
                        StringSplitOptions.RemoveEmptyEntries );
                    
                    if (massivStr [ 13 ] == Order_BOX.Text || massivStr [ 5 ] == Fcs_BOX.Text)
                    {
                        Number = massivStr [ 13 ];
                        Prise = massivStr [ 14 ];
                        DoneWork =  massivStr [ 15 ];
                        while (dataGridView.Rows.Count > 1)
                            dataGridView.Rows.Remove ( dataGridView.Rows [ 0 ] );

                        record ( 0 , 0 , massivStr [ 13 ] );
                        record ( 0 , 1 , massivStr [ 5 ] );
                        record ( 0 , 2 , massivStr [ 7 ] );
                        record ( 0 , 3 , massivStr [ 12 ] );
                        record ( 0 , 4 , massivStr [ 14 ] );
                        record ( 0 , 5 , massivStr [ 0 ] );
                        record ( 0 , 6 , massivStr [ 1 ] );
                        record ( 0 , 7 , massivStr [ 2 ] );
                        record ( 0 , 8 , massivStr [ 3 ] );
                        record ( 0 , 9 , massivStr [ 4 ] );
                        record ( 0 , 10 , massivStr [ 8 ] );
                        record ( 0 , 11 , massivStr [ 11 ] );
                        record ( 0 , 12 , massivStr [ 15 ] );
                        dataGridView.Visible = true;
                        if (massivStr [ 12 ] == "В ремонте")
                        {
                            Issuing_button.Enabled = false;
                            MessageBox.Show ( $"Заказ находится в ремонте! Выдача невозможна!" , "Поиск заказа" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                        }
                        else if (massivStr [ 12 ] == "Выдано")
                        {
                            Issuing_button.Enabled = false;
                            MessageBox.Show ( $"Заказ ранее был выдан! Выдача невозможна!" , "Поиск заказа" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                        }
                        else
                        {
                            Issuing_button.Enabled = true;
                            MessageBox.Show ( $"Заказ готов к выдаче!" , "Поиск заказа" , MessageBoxButtons.OK , MessageBoxIcon.Information );
                        }
                        break;
                    }

                }

            }
            Order_BOX.Text = "";
            Fcs_BOX.Text = "";


        }
        
        public string Number
        {
            get; set;
        }
        private string prise;
        public string Prise
        {
            get; set;
        }
        private string doneWork;
        public string DoneWork
        {
            get; set;
        }
        DataBase dataBase = new DataBase ();
        private void Issuing_Click ( object sender , EventArgs e )
        {
            dataBase.ChangingBD ( Convert.ToInt32(Number) , "Выдано" , Prise , DoneWork, 
                DateTime.Now.ToShortDateString ());
            Order_BOX.Text = "";
            Fcs_BOX.Text = "";
            Issuing_button.Enabled = false;
        }

        
    }
}
