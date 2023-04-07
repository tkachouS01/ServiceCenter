using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Курсовая_АСОИР191_Ткачёв_С.А
{
    public partial class MasterForm : Form
    {
        LoginForm login_form = new LoginForm ();
        public MasterForm ( )
        {
            InitializeComponent ();
        }

        private void GoTo_Authorization_Button_Click ( object sender , EventArgs e )//на авторизацию
        {
            this.Hide ();
            login_form.Show ();
        }

        private void label2_Click ( object sender , EventArgs e ) // выход
        {
            Application.Exit ();
        }
        private void UpdateData_Click ( object sender , EventArgs e ) //обновление таблицы с данными
        {
            Clear_dataGridView ();

            using (var bw = new StreamReader ( file ))
            {
                for (int y = 0 ; ; y++)
                {
                    string str = bw.ReadLine ();
                    if (str == null)
                        break;

                    String [ ] massivStr = str.Split ( new string [ ] { "\t\t" } ,
                        StringSplitOptions.RemoveEmptyEntries );

                    dataGridView.Rows.Add ();
                    if (massivStr [ 12 ] == "Готово" || massivStr [ 12 ] == "Выдано")
                    {
                        dataGridView.Rows [ y ].Visible = false;
                        continue;
                    }

                    record ( y , 0 , massivStr [ 2 ] );
                    record ( y , 1 , massivStr [ 3 ] );
                    record ( y , 2 , massivStr [ 4 ] );
                    record ( y , 3 , massivStr [ 11 ] );
                    record ( y , 4 , massivStr [ 1 ] );
                    record ( y , 5 , massivStr [ 13 ] );

                    if (DateTime.Parse ( massivStr [ 1 ] ) < DateTime.Now)
                    {
                        dataGridView.Rows [ y ].DefaultCellStyle.ForeColor = Color.White;
                        dataGridView.Rows [ y ].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (DateTime.Parse ( massivStr [ 1 ] ) <= ( DateTime.Now.AddDays ( 4 ) ))
                    {
                        dataGridView.Rows [ y ].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else
                    {
                        dataGridView.Rows [ y ].DefaultCellStyle.ForeColor = Color.White;
                        dataGridView.Rows [ y ].DefaultCellStyle.BackColor = Color.Green;
                    }
                }

                dataGridView.ClearSelection ();
            }

        }
        const string file = @"database_file.txt";

        public void Clear_dataGridView ( ) //Очистка таблицы
        {
            while (dataGridView.Rows.Count > 1)
                dataGridView.Rows.Remove ( dataGridView.Rows [ 0 ] );
        }
        public void record ( int y , int x , string element ) // запись в ячейку таблицы
        {
            dataGridView.Rows [ y ].Cells [ x ].Value = Convert.ToString ( element );
        }
        private bool garant;
        public bool Garant
        {
            get
            {
                return garant;
            }

            set
            {
                garant = value;
            }
        }
        private int order;
        public int Order
        {
            get
            {
                return order;
            }

            set
            {
                order = value;
            }
        }


        public bool Check (string number, string status )
        {
            bool check = true;
            using (var bw = new StreamReader ( file ))
            {

                for (int y = 0 ; ; y++)
                {
                    string str = bw.ReadLine ();
                    if (str == null)
                    {
                        MessageBox.Show ( $"Данные не верны!" , "Сохранение данных" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                        check = false;
                        break;
                    }

                    String [ ] massivStr = str.Split ( new string [ ] { "\t\t" } ,
                        StringSplitOptions.RemoveEmptyEntries );


                    if (massivStr [ 13 ] == number)
                    {
                        if (massivStr [ 12 ] != status)
                        {
                            check = false;
                            MessageBox.Show ( $"Заказ ранее был выполнен!" , "Сохранение заказа" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                        }
                        else
                        {
                            Garant = Boolean.Parse(massivStr [ 8 ]);
                            
                            MessageBox.Show ( $"Данные верны!" , "Сохранение заказа" , MessageBoxButtons.OK , MessageBoxIcon.Information );
                        }
                        break;
                    }
                }

            }
            return check;
        }
        DataBase dataBase = new DataBase ();
        private void Save_button_Click ( object sender , EventArgs e )
        {
            string prise = Price_box.Text;
            if (( prise != "") || Garant)
            {
                
                if (Garant)
                    prise = "Бесплатно";
                dataBase.ChangingBD ( int.Parse ( Order_box.Text ) , "Готово" , prise , DoneWork_box.Text, "Дата неизвестна" );
                Order_box.Text = null;
                DoneWork_box.Text = null;
                Price_box.Text = null;
                Price_label.Visible = false;
                Price_box.Visible = false;
                Save_button.Visible = false;
                Garant_label.Visible = false;
            }
            else
                MessageBox.Show ( $"Неверная стоимость!" , "Сохранение данных" , MessageBoxButtons.OK , MessageBoxIcon.Error );

        }
        //*****************************************************************************************************

        

        private void Verify_button_Click ( object sender , EventArgs e )
        {
            Garant_label.Visible = false;
            Save_button.Visible = false;
            if (DoneWork_box.Text != "" && Order_box.Text != " ")
            {
                if (Check ( Order_box.Text , "В ремонте" ))
                {
                    if (Garant)
                    {
                        Price_label.Visible = false;
                        Price_box.Visible = false;
                        Garant_label.Visible = true;
                    }
                    else
                    {
                        Price_label.Visible = true;
                        Price_box.Visible = true;
                    }

                    Save_button.Visible = true;
                }
            }
            else
                MessageBox.Show ( $"Данные не введены!" , "Сохранение данных" , MessageBoxButtons.OK , MessageBoxIcon.Error );

        }



        private void Order_box_TextAlignChanged ( object sender , EventArgs e )
        {
            Price_label.Visible = false;
            Price_box.Visible = false;
            Save_button.Visible = false;
            Garant_label.Visible = false;
        }

        private void DoneWork_box_TextChanged ( object sender , EventArgs e )
        {
            Price_label.Visible = false;
            Price_box.Visible = false;
            Save_button.Visible = false;
            Garant_label.Visible = false;
        }
    }
}
