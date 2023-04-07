using System.Drawing;

namespace Курсовая_АСОИР191_Ткачёв_С.А
{
    partial class MasterForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpdateData_button = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GoTo_Authorization_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Header_label = new System.Windows.Forms.Label();
            this.Save_panel = new System.Windows.Forms.Panel();
            this.Garant_label = new System.Windows.Forms.Label();
            this.Order_box = new System.Windows.Forms.TextBox();
            this.DoneWork_box = new System.Windows.Forms.TextBox();
            this.DoneWork_label = new System.Windows.Forms.Label();
            this.Verify_button = new System.Windows.Forms.Button();
            this.Order_label = new System.Windows.Forms.Label();
            this.Save_button = new System.Windows.Forms.Button();
            this.Price_box = new System.Windows.Forms.MaskedTextBox();
            this.Price_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.Save_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(10)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.UpdateData_button);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Save_panel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 788);
            this.panel1.TabIndex = 0;
            // 
            // UpdateData_button
            // 
            this.UpdateData_button.BackColor = System.Drawing.Color.Gold;
            this.UpdateData_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateData_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateData_button.Location = new System.Drawing.Point(31, 109);
            this.UpdateData_button.Name = "UpdateData_button";
            this.UpdateData_button.Size = new System.Drawing.Size(186, 34);
            this.UpdateData_button.TabIndex = 7;
            this.UpdateData_button.Text = "Обновить данные";
            this.UpdateData_button.UseVisualStyleBackColor = false;
            this.UpdateData_button.Click += new System.EventHandler(this.UpdateData_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView.Enabled = false;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.Location = new System.Drawing.Point(0, 185);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(1366, 585);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.TabStop = false;
            // 
            // Column1
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column1.HeaderText = "Тип";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 230;
            // 
            // Column2
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column2.HeaderText = "Марка";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column3.HeaderText = "Серийный номер";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column4.HeaderText = "Неисправность со слов клиента";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 466;
            // 
            // Column5
            // 
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column5.HeaderText = "Срок исполнения";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column6.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column6.HeaderText = "Номер заказа";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.GoTo_Authorization_Button.TabIndex = 8;
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
            this.label2.TabIndex = 7;
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
            this.Header_label.Text = "Главная форма мастера";
            this.Header_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Save_panel
            // 
            this.Save_panel.BackColor = System.Drawing.Color.Maroon;
            this.Save_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Save_panel.Controls.Add(this.Garant_label);
            this.Save_panel.Controls.Add(this.Order_box);
            this.Save_panel.Controls.Add(this.DoneWork_box);
            this.Save_panel.Controls.Add(this.DoneWork_label);
            this.Save_panel.Controls.Add(this.Verify_button);
            this.Save_panel.Controls.Add(this.Order_label);
            this.Save_panel.Controls.Add(this.Save_button);
            this.Save_panel.Controls.Add(this.Price_box);
            this.Save_panel.Controls.Add(this.Price_label);
            this.Save_panel.Location = new System.Drawing.Point(246, 73);
            this.Save_panel.Name = "Save_panel";
            this.Save_panel.Size = new System.Drawing.Size(1094, 106);
            this.Save_panel.TabIndex = 16;
            // 
            // Garant_label
            // 
            this.Garant_label.AutoSize = true;
            this.Garant_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Garant_label.ForeColor = System.Drawing.Color.White;
            this.Garant_label.Location = new System.Drawing.Point(549, 19);
            this.Garant_label.Name = "Garant_label";
            this.Garant_label.Size = new System.Drawing.Size(202, 24);
            this.Garant_label.TabIndex = 19;
            this.Garant_label.Text = "Гарантийный ремонт";
            this.Garant_label.Visible = false;
            // 
            // Order_box
            // 
            this.Order_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Order_box.Location = new System.Drawing.Point(112, 16);
            this.Order_box.Name = "Order_box";
            this.Order_box.Size = new System.Drawing.Size(72, 29);
            this.Order_box.TabIndex = 18;
            // 
            // DoneWork_box
            // 
            this.DoneWork_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoneWork_box.Location = new System.Drawing.Point(223, 61);
            this.DoneWork_box.Name = "DoneWork_box";
            this.DoneWork_box.Size = new System.Drawing.Size(853, 29);
            this.DoneWork_box.TabIndex = 17;
            this.DoneWork_box.TextChanged += new System.EventHandler(this.DoneWork_box_TextChanged);
            // 
            // DoneWork_label
            // 
            this.DoneWork_label.AutoSize = true;
            this.DoneWork_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoneWork_label.ForeColor = System.Drawing.Color.White;
            this.DoneWork_label.Location = new System.Drawing.Point(19, 64);
            this.DoneWork_label.Name = "DoneWork_label";
            this.DoneWork_label.Size = new System.Drawing.Size(198, 24);
            this.DoneWork_label.TabIndex = 16;
            this.DoneWork_label.Text = "Проделанная работа";
            // 
            // Verify_button
            // 
            this.Verify_button.BackColor = System.Drawing.Color.Orange;
            this.Verify_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Verify_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Verify_button.Location = new System.Drawing.Point(223, 12);
            this.Verify_button.Name = "Verify_button";
            this.Verify_button.Size = new System.Drawing.Size(296, 37);
            this.Verify_button.TabIndex = 15;
            this.Verify_button.Text = "Проверить";
            this.Verify_button.UseVisualStyleBackColor = false;
            this.Verify_button.Click += new System.EventHandler(this.Verify_button_Click);
            // 
            // Order_label
            // 
            this.Order_label.AutoSize = true;
            this.Order_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Order_label.ForeColor = System.Drawing.Color.White;
            this.Order_label.Location = new System.Drawing.Point(19, 19);
            this.Order_label.Name = "Order_label";
            this.Order_label.Size = new System.Drawing.Size(87, 24);
            this.Order_label.TabIndex = 12;
            this.Order_label.Text = "Заказ №";
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.LimeGreen;
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_button.Location = new System.Drawing.Point(780, 14);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(296, 34);
            this.Save_button.TabIndex = 14;
            this.Save_button.Text = "Сохранить данные";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Visible = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Price_box
            // 
            this.Price_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price_box.Location = new System.Drawing.Point(711, 16);
            this.Price_box.Mask = "0000";
            this.Price_box.Name = "Price_box";
            this.Price_box.PromptChar = ' ';
            this.Price_box.Size = new System.Drawing.Size(50, 29);
            this.Price_box.TabIndex = 10;
            this.Price_box.Visible = false;
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price_label.ForeColor = System.Drawing.Color.White;
            this.Price_label.Location = new System.Drawing.Point(537, 19);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(168, 24);
            this.Price_label.TabIndex = 9;
            this.Price_label.Text = "Стоимость работ";
            this.Price_label.Visible = false;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Save_panel.ResumeLayout(false);
            this.Save_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Header_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GoTo_Authorization_Button;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button UpdateData_button;
        private System.Windows.Forms.MaskedTextBox Price_box;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.Panel Save_panel;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label Order_label;
        private System.Windows.Forms.TextBox DoneWork_box;
        private System.Windows.Forms.Label DoneWork_label;
        private System.Windows.Forms.Button Verify_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox Order_box;
        private System.Windows.Forms.Label Garant_label;
    }
}