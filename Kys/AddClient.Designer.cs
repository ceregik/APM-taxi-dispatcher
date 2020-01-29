namespace Kys
{
    partial class AddClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Next = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Driver = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.PlaceF = new System.Windows.Forms.TextBox();
            this.TimeV = new System.Windows.Forms.TextBox();
            this.Abonent = new System.Windows.Forms.TextBox();
            this.PlaceS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(332, 450);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 0;
            this.Next.Text = "Добавить";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Driver
            // 
            this.Driver.Location = new System.Drawing.Point(223, 229);
            this.Driver.Name = "Driver";
            this.Driver.Size = new System.Drawing.Size(100, 20);
            this.Driver.TabIndex = 2;
            this.Driver.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(63, 229);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 3;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(62, 172);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(100, 20);
            this.Phone.TabIndex = 4;
            // 
            // PlaceF
            // 
            this.PlaceF.Location = new System.Drawing.Point(223, 172);
            this.PlaceF.Name = "PlaceF";
            this.PlaceF.Size = new System.Drawing.Size(138, 20);
            this.PlaceF.TabIndex = 5;
            // 
            // TimeV
            // 
            this.TimeV.Location = new System.Drawing.Point(129, 31);
            this.TimeV.Name = "TimeV";
            this.TimeV.Size = new System.Drawing.Size(139, 20);
            this.TimeV.TabIndex = 7;
            this.TimeV.TextChanged += new System.EventHandler(this.TimeV_TextChanged);
            // 
            // Abonent
            // 
            this.Abonent.Location = new System.Drawing.Point(62, 97);
            this.Abonent.Name = "Abonent";
            this.Abonent.Size = new System.Drawing.Size(100, 20);
            this.Abonent.TabIndex = 8;
            // 
            // PlaceS
            // 
            this.PlaceS.Location = new System.Drawing.Point(223, 97);
            this.PlaceS.Name = "PlaceS";
            this.PlaceS.Size = new System.Drawing.Size(141, 20);
            this.PlaceS.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Дата и время назначения ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Абонент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Место отправления";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Телефон абонента";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Место прибытия";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Водители";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Цена";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(192, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Выбор водителя (его позывной)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Fname,
            this.Sname});
            this.dataGridView1.Location = new System.Drawing.Point(44, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(337, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // Number
            // 
            this.Number.HeaderText = "Позывной";
            this.Number.Name = "Number";
            // 
            // Fname
            // 
            this.Fname.HeaderText = "Имя";
            this.Fname.Name = "Fname";
            // 
            // Sname
            // 
            this.Sname.HeaderText = "Фамилия";
            this.Sname.Name = "Sname";
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 485);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlaceS);
            this.Controls.Add(this.Abonent);
            this.Controls.Add(this.TimeV);
            this.Controls.Add(this.PlaceF);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Driver);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Next);
            this.Name = "AddClient";
            this.Text = "Добавление клиента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddClient_FormClosing);
            this.Load += new System.EventHandler(this.AddClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Driver;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox PlaceF;
        private System.Windows.Forms.TextBox TimeV;
        private System.Windows.Forms.TextBox Abonent;
        private System.Windows.Forms.TextBox PlaceS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sname;
    }
}