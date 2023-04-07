using System;

namespace Курсовая_АСОИР191_Ткачёв_С.А
{
    partial class EnteringDataForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Date_box = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Date_label = new System.Windows.Forms.Label();
            this.DateAcceptance_box = new System.Windows.Forms.TextBox();
            this.Phone_masked = new System.Windows.Forms.MaskedTextBox();
            this.FCsReceiver_masked = new System.Windows.Forms.MaskedTextBox();
            this.FCsСlient_masked = new System.Windows.Forms.MaskedTextBox();
            this.SaveDataBase_Button = new System.Windows.Forms.Button();
            this.WarrantyRepair_check = new System.Windows.Forms.CheckBox();
            this.FCsReceiver_label = new System.Windows.Forms.Label();
            this.FCsСlient_label = new System.Windows.Forms.Label();
            this.Phone_label = new System.Windows.Forms.Label();
            this.DateAcceptance_label = new System.Windows.Forms.Label();
            this.WarrantyRepair_label = new System.Windows.Forms.Label();
            this.TechnicalFailures_box = new System.Windows.Forms.TextBox();
            this.TechnicalFailures_label = new System.Windows.Forms.Label();
            this.Appearance_box = new System.Windows.Forms.TextBox();
            this.Appearance_label = new System.Windows.Forms.Label();
            this.Equipment_box = new System.Windows.Forms.TextBox();
            this.Equipment_label = new System.Windows.Forms.Label();
            this.SerialNumber_box = new System.Windows.Forms.TextBox();
            this.SerialNumber_label = new System.Windows.Forms.Label();
            this.ProductBrand_box = new System.Windows.Forms.TextBox();
            this.ProductBrand_label = new System.Windows.Forms.Label();
            this.Type_box = new System.Windows.Forms.TextBox();
            this.Type_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GoTo_Authorization_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Header_label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(10)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.Date_box);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.Date_label);
            this.panel1.Controls.Add(this.DateAcceptance_box);
            this.panel1.Controls.Add(this.Phone_masked);
            this.panel1.Controls.Add(this.FCsReceiver_masked);
            this.panel1.Controls.Add(this.FCsСlient_masked);
            this.panel1.Controls.Add(this.SaveDataBase_Button);
            this.panel1.Controls.Add(this.WarrantyRepair_check);
            this.panel1.Controls.Add(this.FCsReceiver_label);
            this.panel1.Controls.Add(this.FCsСlient_label);
            this.panel1.Controls.Add(this.Phone_label);
            this.panel1.Controls.Add(this.DateAcceptance_label);
            this.panel1.Controls.Add(this.WarrantyRepair_label);
            this.panel1.Controls.Add(this.TechnicalFailures_box);
            this.panel1.Controls.Add(this.TechnicalFailures_label);
            this.panel1.Controls.Add(this.Appearance_box);
            this.panel1.Controls.Add(this.Appearance_label);
            this.panel1.Controls.Add(this.Equipment_box);
            this.panel1.Controls.Add(this.Equipment_label);
            this.panel1.Controls.Add(this.SerialNumber_box);
            this.panel1.Controls.Add(this.SerialNumber_label);
            this.panel1.Controls.Add(this.ProductBrand_box);
            this.panel1.Controls.Add(this.ProductBrand_label);
            this.panel1.Controls.Add(this.Type_box);
            this.panel1.Controls.Add(this.Type_label);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 768);
            this.panel1.TabIndex = 8;
            // 
            // Date_box
            // 
            this.Date_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date_box.Location = new System.Drawing.Point(49, 673);
            this.Date_box.Mask = "00";
            this.Date_box.Name = "Date_box";
            this.Date_box.PromptChar = ' ';
            this.Date_box.Size = new System.Drawing.Size(36, 29);
            this.Date_box.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(91, 676);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 24);
            this.label16.TabIndex = 45;
            this.label16.Text = "дней";
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date_label.ForeColor = System.Drawing.Color.White;
            this.Date_label.Location = new System.Drawing.Point(50, 637);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(169, 24);
            this.Date_label.TabIndex = 43;
            this.Date_label.Text = "Срок выполнения";
            // 
            // DateAcceptance_box
            // 
            this.DateAcceptance_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateAcceptance_box.Location = new System.Drawing.Point(217, 99);
            this.DateAcceptance_box.Name = "DateAcceptance_box";
            this.DateAcceptance_box.ReadOnly = true;
            this.DateAcceptance_box.Size = new System.Drawing.Size(96, 29);
            this.DateAcceptance_box.TabIndex = 41;
            this.DateAcceptance_box.Text = "24.05.2020";
            // 
            // Phone_masked
            // 
            this.Phone_masked.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone_masked.Location = new System.Drawing.Point(238, 355);
            this.Phone_masked.Mask = "+375(00)000-00-00";
            this.Phone_masked.Name = "Phone_masked";
            this.Phone_masked.Size = new System.Drawing.Size(170, 29);
            this.Phone_masked.TabIndex = 38;
            // 
            // FCsReceiver_masked
            // 
            this.FCsReceiver_masked.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FCsReceiver_masked.Location = new System.Drawing.Point(1137, 280);
            this.FCsReceiver_masked.Mask = "L/L/???????????????";
            this.FCsReceiver_masked.Name = "FCsReceiver_masked";
            this.FCsReceiver_masked.Size = new System.Drawing.Size(189, 29);
            this.FCsReceiver_masked.TabIndex = 37;
            // 
            // FCsСlient_masked
            // 
            this.FCsСlient_masked.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FCsСlient_masked.Location = new System.Drawing.Point(49, 280);
            this.FCsСlient_masked.Mask = "L/L/???????????????";
            this.FCsСlient_masked.Name = "FCsСlient_masked";
            this.FCsСlient_masked.Size = new System.Drawing.Size(189, 29);
            this.FCsСlient_masked.TabIndex = 36;
            // 
            // SaveDataBase_Button
            // 
            this.SaveDataBase_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.SaveDataBase_Button.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.SaveDataBase_Button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveDataBase_Button.ForeColor = System.Drawing.Color.White;
            this.SaveDataBase_Button.Location = new System.Drawing.Point(964, 689);
            this.SaveDataBase_Button.Name = "SaveDataBase_Button";
            this.SaveDataBase_Button.Size = new System.Drawing.Size(362, 58);
            this.SaveDataBase_Button.TabIndex = 33;
            this.SaveDataBase_Button.Text = "Добавление в базу данных";
            this.SaveDataBase_Button.UseVisualStyleBackColor = false;
            this.SaveDataBase_Button.Click += new System.EventHandler(this.SaveDataBase_Button_Click );
            // 
            // WarrantyRepair_check
            // 
            this.WarrantyRepair_check.AutoSize = true;
            this.WarrantyRepair_check.BackColor = System.Drawing.Color.White;
            this.WarrantyRepair_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WarrantyRepair_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WarrantyRepair_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WarrantyRepair_check.Location = new System.Drawing.Point(1085, 364);
            this.WarrantyRepair_check.Name = "WarrantyRepair_check";
            this.WarrantyRepair_check.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WarrantyRepair_check.Size = new System.Drawing.Size(12, 11);
            this.WarrantyRepair_check.TabIndex = 32;
            this.WarrantyRepair_check.UseVisualStyleBackColor = false;
            // 
            // FCsReceiver_label
            // 
            this.FCsReceiver_label.AutoSize = true;
            this.FCsReceiver_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FCsReceiver_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FCsReceiver_label.ForeColor = System.Drawing.Color.White;
            this.FCsReceiver_label.Location = new System.Drawing.Point(1157, 247);
            this.FCsReceiver_label.Name = "FCsReceiver_label";
            this.FCsReceiver_label.Size = new System.Drawing.Size(169, 24);
            this.FCsReceiver_label.TabIndex = 30;
            this.FCsReceiver_label.Text = "Ф.И.О приёмщика";
            // 
            // FCsСlient_label
            // 
            this.FCsСlient_label.AutoSize = true;
            this.FCsСlient_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FCsСlient_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FCsСlient_label.ForeColor = System.Drawing.Color.White;
            this.FCsСlient_label.Location = new System.Drawing.Point(50, 249);
            this.FCsСlient_label.Name = "FCsСlient_label";
            this.FCsСlient_label.Size = new System.Drawing.Size(141, 24);
            this.FCsСlient_label.TabIndex = 28;
            this.FCsСlient_label.Text = "Ф.И.О клиента";
            // 
            // Phone_label
            // 
            this.Phone_label.AutoSize = true;
            this.Phone_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Phone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone_label.ForeColor = System.Drawing.Color.White;
            this.Phone_label.Location = new System.Drawing.Point(50, 358);
            this.Phone_label.Name = "Phone_label";
            this.Phone_label.Size = new System.Drawing.Size(162, 24);
            this.Phone_label.TabIndex = 26;
            this.Phone_label.Text = "Номер телефона";
            // 
            // DateAcceptance_label
            // 
            this.DateAcceptance_label.AutoSize = true;
            this.DateAcceptance_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DateAcceptance_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateAcceptance_label.ForeColor = System.Drawing.Color.White;
            this.DateAcceptance_label.Location = new System.Drawing.Point(50, 102);
            this.DateAcceptance_label.Name = "DateAcceptance_label";
            this.DateAcceptance_label.Size = new System.Drawing.Size(136, 24);
            this.DateAcceptance_label.TabIndex = 22;
            this.DateAcceptance_label.Text = "Дата приёмки";
            // 
            // WarrantyRepair_label
            // 
            this.WarrantyRepair_label.AutoSize = true;
            this.WarrantyRepair_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WarrantyRepair_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WarrantyRepair_label.ForeColor = System.Drawing.Color.White;
            this.WarrantyRepair_label.Location = new System.Drawing.Point(1124, 358);
            this.WarrantyRepair_label.Name = "WarrantyRepair_label";
            this.WarrantyRepair_label.Size = new System.Drawing.Size(202, 24);
            this.WarrantyRepair_label.TabIndex = 20;
            this.WarrantyRepair_label.Text = "Гарантийный ремонт";
            // 
            // TechnicalFailures_box
            // 
            this.TechnicalFailures_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TechnicalFailures_box.Location = new System.Drawing.Point(373, 545);
            this.TechnicalFailures_box.Multiline = true;
            this.TechnicalFailures_box.Name = "TechnicalFailures_box";
            this.TechnicalFailures_box.Size = new System.Drawing.Size(953, 116);
            this.TechnicalFailures_box.TabIndex = 19;
            // 
            // TechnicalFailures_label
            // 
            this.TechnicalFailures_label.AutoSize = true;
            this.TechnicalFailures_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TechnicalFailures_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TechnicalFailures_label.ForeColor = System.Drawing.Color.White;
            this.TechnicalFailures_label.Location = new System.Drawing.Point(50, 545);
            this.TechnicalFailures_label.Name = "TechnicalFailures_label";
            this.TechnicalFailures_label.Size = new System.Drawing.Size(301, 24);
            this.TechnicalFailures_label.TabIndex = 18;
            this.TechnicalFailures_label.Text = "Неисправность со слов клиента";
            // 
            // Appearance_box
            // 
            this.Appearance_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Appearance_box.Location = new System.Drawing.Point(195, 491);
            this.Appearance_box.Name = "Appearance_box";
            this.Appearance_box.Size = new System.Drawing.Size(1131, 29);
            this.Appearance_box.TabIndex = 17;
            // 
            // Appearance_label
            // 
            this.Appearance_label.AutoSize = true;
            this.Appearance_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Appearance_label.ForeColor = System.Drawing.Color.White;
            this.Appearance_label.Location = new System.Drawing.Point(50, 494);
            this.Appearance_label.Name = "Appearance_label";
            this.Appearance_label.Size = new System.Drawing.Size(130, 24);
            this.Appearance_label.TabIndex = 16;
            this.Appearance_label.Text = "Внешний вид";
            // 
            // Equipment_box
            // 
            this.Equipment_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Equipment_box.Location = new System.Drawing.Point(195, 434);
            this.Equipment_box.Name = "Equipment_box";
            this.Equipment_box.Size = new System.Drawing.Size(1131, 29);
            this.Equipment_box.TabIndex = 15;
            // 
            // Equipment_label
            // 
            this.Equipment_label.AutoSize = true;
            this.Equipment_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Equipment_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Equipment_label.ForeColor = System.Drawing.Color.White;
            this.Equipment_label.Location = new System.Drawing.Point(50, 437);
            this.Equipment_label.Name = "Equipment_label";
            this.Equipment_label.Size = new System.Drawing.Size(139, 24);
            this.Equipment_label.TabIndex = 14;
            this.Equipment_label.Text = "Комплектация";
            // 
            // SerialNumber_box
            // 
            this.SerialNumber_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SerialNumber_box.Location = new System.Drawing.Point(911, 165);
            this.SerialNumber_box.Name = "SerialNumber_box";
            this.SerialNumber_box.Size = new System.Drawing.Size(212, 29);
            this.SerialNumber_box.TabIndex = 13;
            // 
            // SerialNumber_label
            // 
            this.SerialNumber_label.AutoSize = true;
            this.SerialNumber_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SerialNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SerialNumber_label.ForeColor = System.Drawing.Color.White;
            this.SerialNumber_label.Location = new System.Drawing.Point(765, 168);
            this.SerialNumber_label.Name = "SerialNumber_label";
            this.SerialNumber_label.Size = new System.Drawing.Size(127, 24);
            this.SerialNumber_label.TabIndex = 12;
            this.SerialNumber_label.Text = "Серийный №";
            // 
            // ProductBrand_box
            // 
            this.ProductBrand_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductBrand_box.Location = new System.Drawing.Point(475, 165);
            this.ProductBrand_box.Name = "ProductBrand_box";
            this.ProductBrand_box.Size = new System.Drawing.Size(212, 29);
            this.ProductBrand_box.TabIndex = 11;
            // 
            // ProductBrand_label
            // 
            this.ProductBrand_label.AutoSize = true;
            this.ProductBrand_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProductBrand_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductBrand_label.ForeColor = System.Drawing.Color.White;
            this.ProductBrand_label.Location = new System.Drawing.Point(390, 168);
            this.ProductBrand_label.Name = "ProductBrand_label";
            this.ProductBrand_label.Size = new System.Drawing.Size(66, 24);
            this.ProductBrand_label.TabIndex = 10;
            this.ProductBrand_label.Text = "Марка";
            // 
            // Type_box
            // 
            this.Type_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type_box.Location = new System.Drawing.Point(113, 165);
            this.Type_box.Name = "Type_box";
            this.Type_box.Size = new System.Drawing.Size(212, 29);
            this.Type_box.TabIndex = 9;
            // 
            // Type_label
            // 
            this.Type_label.AutoSize = true;
            this.Type_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type_label.ForeColor = System.Drawing.Color.White;
            this.Type_label.Location = new System.Drawing.Point(50, 168);
            this.Type_label.Name = "Type_label";
            this.Type_label.Size = new System.Drawing.Size(44, 24);
            this.Type_label.TabIndex = 8;
            this.Type_label.Text = "Тип";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(12)))), ((int)(((byte)(6)))));
            this.panel2.Controls.Add(this.GoTo_Authorization_Button);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Header_label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 67);
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
            this.GoTo_Authorization_Button.TabIndex = 7;
            this.GoTo_Authorization_Button.Text = "Выйти из уч.записи";
            this.GoTo_Authorization_Button.UseVisualStyleBackColor = false;
            this.GoTo_Authorization_Button.Click += new System.EventHandler(this.GoTo_Authorization_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1346, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "x";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Header_label1
            // 
            this.Header_label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header_label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Header_label1.Location = new System.Drawing.Point(0, 0);
            this.Header_label1.Name = "Header_label1";
            this.Header_label1.Size = new System.Drawing.Size(1366, 67);
            this.Header_label1.TabIndex = 6;
            this.Header_label1.Text = "Добавление новых данных";
            this.Header_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnteringDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnteringDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnteringDataForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EnteringDataForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveDataBase_Button;
        private System.Windows.Forms.CheckBox WarrantyRepair_check;
        private System.Windows.Forms.Label FCsReceiver_label;
        private System.Windows.Forms.Label FCsСlient_label;
        private System.Windows.Forms.Label Phone_label;
        private System.Windows.Forms.Label DateAcceptance_label;
        private System.Windows.Forms.Label WarrantyRepair_label;
        private System.Windows.Forms.TextBox TechnicalFailures_box;
        private System.Windows.Forms.Label TechnicalFailures_label;
        private System.Windows.Forms.TextBox Appearance_box;
        private System.Windows.Forms.Label Appearance_label;
        private System.Windows.Forms.TextBox Equipment_box;
        private System.Windows.Forms.Label Equipment_label;
        private System.Windows.Forms.TextBox SerialNumber_box;
        private System.Windows.Forms.Label SerialNumber_label;
        private System.Windows.Forms.TextBox ProductBrand_box;
        private System.Windows.Forms.Label ProductBrand_label;
        private System.Windows.Forms.TextBox Type_box;
        private System.Windows.Forms.Label Type_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button GoTo_Authorization_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Header_label1;
        private System.Windows.Forms.MaskedTextBox Phone_masked;
        private System.Windows.Forms.MaskedTextBox FCsReceiver_masked;
        private System.Windows.Forms.MaskedTextBox FCsСlient_masked;
        private System.Windows.Forms.TextBox DateAcceptance_box;
        private System.Windows.Forms.MaskedTextBox Date_box;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label Date_label;
    }
}