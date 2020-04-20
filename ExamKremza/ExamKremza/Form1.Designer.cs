namespace ExamKremza
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.brigadeTB = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sortB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.capacityTB = new System.Windows.Forms.TextBox();
            this.departureTB = new System.Windows.Forms.TextBox();
            this.timeTB = new System.Windows.Forms.TextBox();
            this.dateTB = new System.Windows.Forms.TextBox();
            this.destinationTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.redB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.redBrigadeTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.redNumberTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.redDestinationTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.redDateTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.redTimeTB = new System.Windows.Forms.TextBox();
            this.redCapacityTB = new System.Windows.Forms.TextBox();
            this.redDepartureTB = new System.Windows.Forms.TextBox();
            this.overviewB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.brigadeTB);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.sortB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.capacityTB);
            this.groupBox1.Controls.Add(this.departureTB);
            this.groupBox1.Controls.Add(this.timeTB);
            this.groupBox1.Controls.Add(this.dateTB);
            this.groupBox1.Controls.Add(this.destinationTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(246, 146);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(124, 17);
            this.checkBox6.TabIndex = 19;
            this.checkBox6.Text = "Учитывать бригаду";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Бригада:";
            // 
            // brigadeTB
            // 
            this.brigadeTB.Enabled = false;
            this.brigadeTB.Location = new System.Drawing.Point(140, 143);
            this.brigadeTB.Name = "brigadeTB";
            this.brigadeTB.Size = new System.Drawing.Size(100, 20);
            this.brigadeTB.TabIndex = 17;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(246, 120);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(170, 17);
            this.checkBox5.TabIndex = 16;
            this.checkBox5.Text = "Учитывать количество мест";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(246, 94);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(184, 17);
            this.checkBox4.TabIndex = 15;
            this.checkBox4.Text = "Учитывать время отправления";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(246, 68);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(174, 17);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "Учитывать дату отправления";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(246, 41);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(174, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Учитывать пункт назначения";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(246, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(180, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Учитывать пункт отправления";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Количество мест:";
            // 
            // sortB
            // 
            this.sortB.Location = new System.Drawing.Point(9, 191);
            this.sortB.Name = "sortB";
            this.sortB.Size = new System.Drawing.Size(231, 23);
            this.sortB.TabIndex = 20;
            this.sortB.Text = "Сортировать";
            this.sortB.Click += new System.EventHandler(this.sortB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Время отправления:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Дата отправления:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пункт назначения:";
            // 
            // capacityTB
            // 
            this.capacityTB.Enabled = false;
            this.capacityTB.Location = new System.Drawing.Point(140, 117);
            this.capacityTB.Name = "capacityTB";
            this.capacityTB.Size = new System.Drawing.Size(100, 20);
            this.capacityTB.TabIndex = 7;
            // 
            // departureTB
            // 
            this.departureTB.Enabled = false;
            this.departureTB.Location = new System.Drawing.Point(140, 13);
            this.departureTB.Name = "departureTB";
            this.departureTB.Size = new System.Drawing.Size(100, 20);
            this.departureTB.TabIndex = 2;
            // 
            // timeTB
            // 
            this.timeTB.Enabled = false;
            this.timeTB.Location = new System.Drawing.Point(140, 91);
            this.timeTB.Name = "timeTB";
            this.timeTB.Size = new System.Drawing.Size(100, 20);
            this.timeTB.TabIndex = 4;
            // 
            // dateTB
            // 
            this.dateTB.Enabled = false;
            this.dateTB.Location = new System.Drawing.Point(140, 65);
            this.dateTB.Name = "dateTB";
            this.dateTB.Size = new System.Drawing.Size(100, 20);
            this.dateTB.TabIndex = 5;
            // 
            // destinationTB
            // 
            this.destinationTB.Enabled = false;
            this.destinationTB.Location = new System.Drawing.Point(140, 39);
            this.destinationTB.Name = "destinationTB";
            this.destinationTB.Size = new System.Drawing.Size(100, 20);
            this.destinationTB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Пункт отправления:";
            // 
            // redB
            // 
            this.redB.Location = new System.Drawing.Point(9, 213);
            this.redB.Name = "redB";
            this.redB.Size = new System.Drawing.Size(231, 23);
            this.redB.TabIndex = 2;
            this.redB.Text = "Отредактировать";
            this.redB.UseVisualStyleBackColor = true;
            this.redB.Click += new System.EventHandler(this.redB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(721, 283);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.redBrigadeTB);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.redNumberTB);
            this.groupBox2.Controls.Add(this.redB);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.redDestinationTB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.redDateTB);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.redTimeTB);
            this.groupBox2.Controls.Add(this.redCapacityTB);
            this.groupBox2.Controls.Add(this.redDepartureTB);
            this.groupBox2.Location = new System.Drawing.Point(482, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 242);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактирование";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Бригада:";
            // 
            // redBrigadeTB
            // 
            this.redBrigadeTB.Location = new System.Drawing.Point(140, 169);
            this.redBrigadeTB.Name = "redBrigadeTB";
            this.redBrigadeTB.Size = new System.Drawing.Size(100, 20);
            this.redBrigadeTB.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Номер рейса:";
            // 
            // redNumberTB
            // 
            this.redNumberTB.Location = new System.Drawing.Point(140, 14);
            this.redNumberTB.Name = "redNumberTB";
            this.redNumberTB.Size = new System.Drawing.Size(100, 20);
            this.redNumberTB.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Количество мест:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Пункт отправления:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Время отправления:";
            // 
            // redDestinationTB
            // 
            this.redDestinationTB.Location = new System.Drawing.Point(140, 65);
            this.redDestinationTB.Name = "redDestinationTB";
            this.redDestinationTB.Size = new System.Drawing.Size(100, 20);
            this.redDestinationTB.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Дата отправления:";
            // 
            // redDateTB
            // 
            this.redDateTB.Location = new System.Drawing.Point(140, 91);
            this.redDateTB.Name = "redDateTB";
            this.redDateTB.Size = new System.Drawing.Size(100, 20);
            this.redDateTB.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Пункт назначения:";
            // 
            // redTimeTB
            // 
            this.redTimeTB.Location = new System.Drawing.Point(140, 117);
            this.redTimeTB.Name = "redTimeTB";
            this.redTimeTB.Size = new System.Drawing.Size(100, 20);
            this.redTimeTB.TabIndex = 19;
            // 
            // redCapacityTB
            // 
            this.redCapacityTB.Location = new System.Drawing.Point(140, 143);
            this.redCapacityTB.Name = "redCapacityTB";
            this.redCapacityTB.Size = new System.Drawing.Size(100, 20);
            this.redCapacityTB.TabIndex = 22;
            // 
            // redDepartureTB
            // 
            this.redDepartureTB.Location = new System.Drawing.Point(140, 39);
            this.redDepartureTB.Name = "redDepartureTB";
            this.redDepartureTB.Size = new System.Drawing.Size(100, 20);
            this.redDepartureTB.TabIndex = 17;
            // 
            // overviewB
            // 
            this.overviewB.Location = new System.Drawing.Point(622, 558);
            this.overviewB.Name = "overviewB";
            this.overviewB.Size = new System.Drawing.Size(112, 23);
            this.overviewB.TabIndex = 5;
            this.overviewB.Text = "Сделать выписку";
            this.overviewB.UseVisualStyleBackColor = true;
            this.overviewB.Click += new System.EventHandler(this.overviewB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 593);
            this.Controls.Add(this.overviewB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox capacityTB;
        private System.Windows.Forms.TextBox departureTB;
        private System.Windows.Forms.TextBox timeTB;
        private System.Windows.Forms.TextBox dateTB;
        private System.Windows.Forms.TextBox destinationTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sortB;
        private System.Windows.Forms.Button redB;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox redNumberTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox redDestinationTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox redDateTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox redTimeTB;
        private System.Windows.Forms.TextBox redCapacityTB;
        private System.Windows.Forms.TextBox redDepartureTB;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox brigadeTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox redBrigadeTB;
        private System.Windows.Forms.Button overviewB;
    }
}

