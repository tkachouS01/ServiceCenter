namespace Курсовая_АСОИР191_Ткачёв_С.А
{
    partial class ReceiverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && ( components != null ))
            {
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IssuingOrder_panel = new System.Windows.Forms.Panel();
            this.Issuing_button = new System.Windows.Forms.Button();
            this.Fcs_BOX = new System.Windows.Forms.MaskedTextBox();
            this.Order_BOX = new System.Windows.Forms.MaskedTextBox();
            this.or_label = new System.Windows.Forms.Label();
            this.Retrieval_button = new System.Windows.Forms.Button();
            this.Oder_label = new System.Windows.Forms.Label();
            this.Fcs_label = new System.Windows.Forms.Label();
            this.TotalRevenue_panel = new System.Windows.Forms.Panel();
            this.Time_label = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.TotalRevenue_box = new System.Windows.Forms.TextBox();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.TotalRevenue_label = new System.Windows.Forms.Label();
            this.Calculate_button = new System.Windows.Forms.Button();
            this.With_label = new System.Windows.Forms.Label();
            this.By_label = new System.Windows.Forms.Label();
            this.IssuingOrder_button = new System.Windows.Forms.Button();
            this.ListOrder_button = new System.Windows.Forms.Button();
            this.TotalRevenue_button = new System.Windows.Forms.Button();
            this.NewOrder_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GoTo_Authorization_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Header_label = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.IssuingOrder_panel.SuspendLayout();
            this.TotalRevenue_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(10)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.IssuingOrder_panel);
            this.panel1.Controls.Add(this.TotalRevenue_panel);
            this.panel1.Controls.Add(this.IssuingOrder_button);
            this.panel1.Controls.Add(this.ListOrder_button);
            this.panel1.Controls.Add(this.TotalRevenue_button);
            this.panel1.Controls.Add(this.NewOrder_button);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 788);
            this.panel1.TabIndex = 0;
            // 
            // IssuingOrder_panel
            // 
            this.IssuingOrder_panel.Controls.Add(this.Issuing_button);
            this.IssuingOrder_panel.Controls.Add(this.Fcs_BOX);
            this.IssuingOrder_panel.Controls.Add(this.Order_BOX);
            this.IssuingOrder_panel.Controls.Add(this.or_label);
            this.IssuingOrder_panel.Controls.Add(this.Retrieval_button);
            this.IssuingOrder_panel.Controls.Add(this.Oder_label);
            this.IssuingOrder_panel.Controls.Add(this.Fcs_label);
            this.IssuingOrder_panel.Location = new System.Drawing.Point(191, 185);
            this.IssuingOrder_panel.Name = "IssuingOrder_panel";
            this.IssuingOrder_panel.Size = new System.Drawing.Size(676, 99);
            this.IssuingOrder_panel.TabIndex = 21;
            this.IssuingOrder_panel.Visible = false;
            // 
            // Issuing_button
            // 
            this.Issuing_button.BackColor = System.Drawing.Color.LimeGreen;
            this.Issuing_button.Enabled = false;
            this.Issuing_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Issuing_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Issuing_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Issuing_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Issuing_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Issuing_button.Location = new System.Drawing.Point(446, 52);
            this.Issuing_button.Name = "Issuing_button";
            this.Issuing_button.Size = new System.Drawing.Size(227, 41);
            this.Issuing_button.TabIndex = 6;
            this.Issuing_button.Text = "Выдача";
            this.Issuing_button.UseVisualStyleBackColor = false;
            this.Issuing_button.Click += new System.EventHandler(this.Issuing_Click);
            // 
            // Fcs_BOX
            // 
            this.Fcs_BOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fcs_BOX.Location = new System.Drawing.Point(204, 58);
            this.Fcs_BOX.Mask = "L/L/???????????????";
            this.Fcs_BOX.Name = "Fcs_BOX";
            this.Fcs_BOX.Size = new System.Drawing.Size(151, 29);
            this.Fcs_BOX.TabIndex = 5;
            // 
            // Order_BOX
            // 
            this.Order_BOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Order_BOX.Location = new System.Drawing.Point(154, 14);
            this.Order_BOX.Mask = "00000";
            this.Order_BOX.Name = "Order_BOX";
            this.Order_BOX.Size = new System.Drawing.Size(57, 29);
            this.Order_BOX.TabIndex = 4;
            // 
            // or_label
            // 
            this.or_label.AutoSize = true;
            this.or_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.or_label.ForeColor = System.Drawing.Color.White;
            this.or_label.Location = new System.Drawing.Point(7, 40);
            this.or_label.Name = "or_label";
            this.or_label.Size = new System.Drawing.Size(37, 20);
            this.or_label.TabIndex = 3;
            this.or_label.Text = "или";
            // 
            // Retrieval_button
            // 
            this.Retrieval_button.BackColor = System.Drawing.Color.Orange;
            this.Retrieval_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Retrieval_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Retrieval_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Retrieval_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Retrieval_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Retrieval_button.Location = new System.Drawing.Point(446, 3);
            this.Retrieval_button.Name = "Retrieval_button";
            this.Retrieval_button.Size = new System.Drawing.Size(227, 41);
            this.Retrieval_button.TabIndex = 2;
            this.Retrieval_button.Text = "Поиск информации";
            this.Retrieval_button.UseVisualStyleBackColor = false;
            this.Retrieval_button.Click += new System.EventHandler(this.Retrieval_Click);
            // 
            // Oder_label
            // 
            this.Oder_label.AutoSize = true;
            this.Oder_label.BackColor = System.Drawing.Color.Orange;
            this.Oder_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Oder_label.Location = new System.Drawing.Point(50, 16);
            this.Oder_label.Name = "Oder_label";
            this.Oder_label.Size = new System.Drawing.Size(98, 25);
            this.Oder_label.TabIndex = 1;
            this.Oder_label.Text = "Заказ №";
            // 
            // Fcs_label
            // 
            this.Fcs_label.AutoSize = true;
            this.Fcs_label.BackColor = System.Drawing.Color.Orange;
            this.Fcs_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fcs_label.Location = new System.Drawing.Point(50, 60);
            this.Fcs_label.Name = "Fcs_label";
            this.Fcs_label.Size = new System.Drawing.Size(148, 25);
            this.Fcs_label.TabIndex = 0;
            this.Fcs_label.Text = "ФИО клиента";
            // 
            // TotalRevenue_panel
            // 
            this.TotalRevenue_panel.Controls.Add(this.Time_label);
            this.TotalRevenue_panel.Controls.Add(this.date1);
            this.TotalRevenue_panel.Controls.Add(this.TotalRevenue_box);
            this.TotalRevenue_panel.Controls.Add(this.date2);
            this.TotalRevenue_panel.Controls.Add(this.TotalRevenue_label);
            this.TotalRevenue_panel.Controls.Add(this.Calculate_button);
            this.TotalRevenue_panel.Controls.Add(this.With_label);
            this.TotalRevenue_panel.Controls.Add(this.By_label);
            this.TotalRevenue_panel.Location = new System.Drawing.Point(995, 156);
            this.TotalRevenue_panel.Name = "TotalRevenue_panel";
            this.TotalRevenue_panel.Size = new System.Drawing.Size(289, 264);
            this.TotalRevenue_panel.TabIndex = 19;
            this.TotalRevenue_panel.Visible = false;
            // 
            // Time_label
            // 
            this.Time_label.AutoSize = true;
            this.Time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time_label.ForeColor = System.Drawing.Color.White;
            this.Time_label.Location = new System.Drawing.Point(54, 0);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(196, 25);
            this.Time_label.TabIndex = 13;
            this.Time_label.Text = "Временные рамки";
            // 
            // date1
            // 
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date1.Location = new System.Drawing.Point(50, 38);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(200, 31);
            this.date1.TabIndex = 11;
            this.date1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TotalRevenue_box
            // 
            this.TotalRevenue_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalRevenue_box.Location = new System.Drawing.Point(50, 224);
            this.TotalRevenue_box.Name = "TotalRevenue_box";
            this.TotalRevenue_box.Size = new System.Drawing.Size(200, 31);
            this.TotalRevenue_box.TabIndex = 18;
            this.TotalRevenue_box.Visible = false;
            // 
            // date2
            // 
            this.date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date2.Location = new System.Drawing.Point(50, 74);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(200, 31);
            this.date2.TabIndex = 12;
            // 
            // TotalRevenue_label
            // 
            this.TotalRevenue_label.AutoSize = true;
            this.TotalRevenue_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalRevenue_label.ForeColor = System.Drawing.Color.White;
            this.TotalRevenue_label.Location = new System.Drawing.Point(45, 196);
            this.TotalRevenue_label.Name = "TotalRevenue_label";
            this.TotalRevenue_label.Size = new System.Drawing.Size(146, 25);
            this.TotalRevenue_label.TabIndex = 16;
            this.TotalRevenue_label.Text = "Общий доход";
            this.TotalRevenue_label.Visible = false;
            // 
            // Calculate_button
            // 
            this.Calculate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculate_button.Location = new System.Drawing.Point(50, 142);
            this.Calculate_button.Name = "Calculate_button";
            this.Calculate_button.Size = new System.Drawing.Size(200, 41);
            this.Calculate_button.TabIndex = 17;
            this.Calculate_button.Text = "Рассчитать";
            this.Calculate_button.UseVisualStyleBackColor = true;
            this.Calculate_button.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // With_label
            // 
            this.With_label.AutoSize = true;
            this.With_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.With_label.ForeColor = System.Drawing.Color.White;
            this.With_label.Location = new System.Drawing.Point(15, 43);
            this.With_label.Name = "With_label";
            this.With_label.Size = new System.Drawing.Size(27, 25);
            this.With_label.TabIndex = 14;
            this.With_label.Text = "С";
            // 
            // By_label
            // 
            this.By_label.AutoSize = true;
            this.By_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.By_label.ForeColor = System.Drawing.Color.White;
            this.By_label.Location = new System.Drawing.Point(3, 79);
            this.By_label.Name = "By_label";
            this.By_label.Size = new System.Drawing.Size(39, 25);
            this.By_label.TabIndex = 15;
            this.By_label.Text = "По";
            // 
            // IssuingOrder_button
            // 
            this.IssuingOrder_button.BackColor = System.Drawing.Color.Snow;
            this.IssuingOrder_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IssuingOrder_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IssuingOrder_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IssuingOrder_button.Location = new System.Drawing.Point(439, 93);
            this.IssuingOrder_button.Name = "IssuingOrder_button";
            this.IssuingOrder_button.Size = new System.Drawing.Size(219, 39);
            this.IssuingOrder_button.TabIndex = 10;
            this.IssuingOrder_button.Text = "Выдача заказа";
            this.IssuingOrder_button.UseVisualStyleBackColor = false;
            this.IssuingOrder_button.Click += new System.EventHandler(this.IssuingOrder_Click);
            // 
            // ListOrder_button
            // 
            this.ListOrder_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.ListOrder_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListOrder_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListOrder_button.Location = new System.Drawing.Point(664, 93);
            this.ListOrder_button.Name = "ListOrder_button";
            this.ListOrder_button.Size = new System.Drawing.Size(219, 39);
            this.ListOrder_button.TabIndex = 9;
            this.ListOrder_button.Text = "Список заказов";
            this.ListOrder_button.UseVisualStyleBackColor = false;
            this.ListOrder_button.Click += new System.EventHandler(this.ListOrder_Click);
            // 
            // TotalRevenue_button
            // 
            this.TotalRevenue_button.BackColor = System.Drawing.Color.Snow;
            this.TotalRevenue_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalRevenue_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalRevenue_button.Location = new System.Drawing.Point(889, 93);
            this.TotalRevenue_button.Name = "TotalRevenue_button";
            this.TotalRevenue_button.Size = new System.Drawing.Size(175, 39);
            this.TotalRevenue_button.TabIndex = 7;
            this.TotalRevenue_button.Text = "Общий доход";
            this.TotalRevenue_button.UseVisualStyleBackColor = false;
            this.TotalRevenue_button.Click += new System.EventHandler(this.TotalRevenue_Click);
            // 
            // NewOrder_button
            // 
            this.NewOrder_button.BackColor = System.Drawing.Color.Snow;
            this.NewOrder_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewOrder_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewOrder_button.Location = new System.Drawing.Point(258, 93);
            this.NewOrder_button.Name = "NewOrder_button";
            this.NewOrder_button.Size = new System.Drawing.Size(175, 39);
            this.NewOrder_button.TabIndex = 6;
            this.NewOrder_button.Text = "Новый заказ";
            this.NewOrder_button.UseVisualStyleBackColor = false;
            this.NewOrder_button.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(12)))), ((int)(((byte)(6)))));
            this.panel2.Controls.Add(this.GoTo_Authorization_Button);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Header_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1386, 67);
            this.panel2.TabIndex = 5;
            // 
            // GoTo_Authorization_Button
            // 
            this.GoTo_Authorization_Button.BackColor = System.Drawing.Color.White;
            this.GoTo_Authorization_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoTo_Authorization_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoTo_Authorization_Button.Location = new System.Drawing.Point(1130, 12);
            this.GoTo_Authorization_Button.Name = "GoTo_Authorization_Button";
            this.GoTo_Authorization_Button.Size = new System.Drawing.Size(210, 37);
            this.GoTo_Authorization_Button.TabIndex = 11;
            this.GoTo_Authorization_Button.Text = "Выйти из уч.записи";
            this.GoTo_Authorization_Button.UseVisualStyleBackColor = false;
            this.GoTo_Authorization_Button.Click += new System.EventHandler(this.GoTo_Authorization_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1346, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "x";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Header_label
            // 
            this.Header_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_label.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Header_label.Location = new System.Drawing.Point(0, 0);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(1386, 67);
            this.Header_label.TabIndex = 6;
            this.Header_label.Text = "Главная форма приёмщика";
            this.Header_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column11,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column12,
            this.Column13});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.Location = new System.Drawing.Point(0, 142);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(1408, 627);
            this.dataGridView.TabIndex = 20;
            this.dataGridView.TabStop = false;
            // 
            // Column10
            // 
            this.Column10.Frozen = true;
            this.Column10.HeaderText = "№";
            this.Column10.Name = "Column10";
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column10.Width = 30;
            // 
            // Column6
            // 
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "ФИО клиента";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 120;
            // 
            // Column7
            // 
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "Телефон";
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 135;
            // 
            // Column9
            // 
            this.Column9.Frozen = true;
            this.Column9.HeaderText = "Статус выполнения";
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Width = 90;
            // 
            // Column11
            // 
            this.Column11.Frozen = true;
            this.Column11.HeaderText = "Стоимость работ";
            this.Column11.Name = "Column11";
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column11.Width = 90;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Дата приёмки";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 85;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Дата выполнения";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 95;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Тип";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Марка";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Серийный номер";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 90;
            // 
            // Column8
            // 
            this.Column8.Frozen = true;
            this.Column8.HeaderText = "Гарант. ремонт";
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 60;
            // 
            // Column12
            // 
            this.Column12.Frozen = true;
            this.Column12.HeaderText = "Неисправность";
            this.Column12.Name = "Column12";
            this.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column12.Width = 220;
            // 
            // Column13
            // 
            this.Column13.Frozen = true;
            this.Column13.HeaderText = "Проделанная работа";
            this.Column13.Name = "Column13";
            this.Column13.Width = 181;
            // 
            // ReceiverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceiverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceiverForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.IssuingOrder_panel.ResumeLayout(false);
            this.IssuingOrder_panel.PerformLayout();
            this.TotalRevenue_panel.ResumeLayout(false);
            this.TotalRevenue_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Header_label;
        private System.Windows.Forms.Button TotalRevenue_button;
        private System.Windows.Forms.Button NewOrder_button;
        private System.Windows.Forms.Button ListOrder_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GoTo_Authorization_Button;
        private System.Windows.Forms.Button IssuingOrder_button;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel TotalRevenue_panel;
        private System.Windows.Forms.Label Time_label;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.TextBox TotalRevenue_box;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Label TotalRevenue_label;
        private System.Windows.Forms.Button Calculate_button;
        private System.Windows.Forms.Label With_label;
        private System.Windows.Forms.Label By_label;
        private System.Windows.Forms.Panel IssuingOrder_panel;
        private System.Windows.Forms.Label or_label;
        private System.Windows.Forms.Button Retrieval_button;
        private System.Windows.Forms.Label Oder_label;
        private System.Windows.Forms.Label Fcs_label;
        private System.Windows.Forms.MaskedTextBox Fcs_BOX;
        private System.Windows.Forms.MaskedTextBox Order_BOX;
        private System.Windows.Forms.Button Issuing_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}