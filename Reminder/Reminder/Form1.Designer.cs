namespace Reminder
{
    partial class Mainform
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
            this.components = new System.ComponentModel.Container();
            this.realTimelabel = new System.Windows.Forms.Label();
            this.realTimetimer = new System.Windows.Forms.Timer(this.components);
            this.remindermaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.remindermaskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.remindermaskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.remindermaskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.remindermaskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.remindertextBox1 = new System.Windows.Forms.TextBox();
            this.remindertextBox2 = new System.Windows.Forms.TextBox();
            this.remindertextBox3 = new System.Windows.Forms.TextBox();
            this.remindertextBox4 = new System.Windows.Forms.TextBox();
            this.remindertextBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.remindertimer1 = new System.Windows.Forms.Timer(this.components);
            this.remindertimer2 = new System.Windows.Forms.Timer(this.components);
            this.remindertimer3 = new System.Windows.Forms.Timer(this.components);
            this.remindertimer4 = new System.Windows.Forms.Timer(this.components);
            this.remindertimer5 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // realTimelabel
            // 
            this.realTimelabel.AutoSize = true;
            this.realTimelabel.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.realTimelabel.Location = new System.Drawing.Point(12, 9);
            this.realTimelabel.Name = "realTimelabel";
            this.realTimelabel.Size = new System.Drawing.Size(116, 31);
            this.realTimelabel.TabIndex = 0;
            this.realTimelabel.Text = "label1";
            // 
            // realTimetimer
            // 
            this.realTimetimer.Enabled = true;
            this.realTimetimer.Interval = 1000;
            this.realTimetimer.Tick += new System.EventHandler(this.realTimetimer_Tick);
            // 
            // remindermaskedTextBox1
            // 
            this.remindermaskedTextBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remindermaskedTextBox1.Location = new System.Drawing.Point(536, 50);
            this.remindermaskedTextBox1.Mask = "00:00:0000";
            this.remindermaskedTextBox1.Name = "remindermaskedTextBox1";
            this.remindermaskedTextBox1.Size = new System.Drawing.Size(147, 30);
            this.remindermaskedTextBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Популов Евгений ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(243, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last name, first name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(532, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date of birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Полищук Павел";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Тюрина Маргарита";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Питянова Анастасия";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(14, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Кириченко Дмитрий";
            // 
            // remindermaskedTextBox2
            // 
            this.remindermaskedTextBox2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remindermaskedTextBox2.Location = new System.Drawing.Point(536, 86);
            this.remindermaskedTextBox2.Mask = "00:00:0000";
            this.remindermaskedTextBox2.Name = "remindermaskedTextBox2";
            this.remindermaskedTextBox2.Size = new System.Drawing.Size(147, 30);
            this.remindermaskedTextBox2.TabIndex = 10;
            // 
            // remindermaskedTextBox3
            // 
            this.remindermaskedTextBox3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remindermaskedTextBox3.Location = new System.Drawing.Point(536, 122);
            this.remindermaskedTextBox3.Mask = "00:00:0000";
            this.remindermaskedTextBox3.Name = "remindermaskedTextBox3";
            this.remindermaskedTextBox3.Size = new System.Drawing.Size(147, 30);
            this.remindermaskedTextBox3.TabIndex = 11;
            // 
            // remindermaskedTextBox4
            // 
            this.remindermaskedTextBox4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remindermaskedTextBox4.Location = new System.Drawing.Point(536, 158);
            this.remindermaskedTextBox4.Mask = "00:00:0000";
            this.remindermaskedTextBox4.Name = "remindermaskedTextBox4";
            this.remindermaskedTextBox4.Size = new System.Drawing.Size(147, 30);
            this.remindermaskedTextBox4.TabIndex = 12;
            // 
            // remindermaskedTextBox5
            // 
            this.remindermaskedTextBox5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remindermaskedTextBox5.Location = new System.Drawing.Point(536, 195);
            this.remindermaskedTextBox5.Mask = "00:00:0000";
            this.remindermaskedTextBox5.Name = "remindermaskedTextBox5";
            this.remindermaskedTextBox5.Size = new System.Drawing.Size(147, 30);
            this.remindermaskedTextBox5.TabIndex = 13;
            // 
            // remindertextBox1
            // 
            this.remindertextBox1.Location = new System.Drawing.Point(269, 54);
            this.remindertextBox1.Multiline = true;
            this.remindertextBox1.Name = "remindertextBox1";
            this.remindertextBox1.Size = new System.Drawing.Size(183, 22);
            this.remindertextBox1.TabIndex = 14;
            this.remindertextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // remindertextBox2
            // 
            this.remindertextBox2.Location = new System.Drawing.Point(269, 94);
            this.remindertextBox2.Multiline = true;
            this.remindertextBox2.Name = "remindertextBox2";
            this.remindertextBox2.Size = new System.Drawing.Size(183, 22);
            this.remindertextBox2.TabIndex = 15;
            // 
            // remindertextBox3
            // 
            this.remindertextBox3.Location = new System.Drawing.Point(269, 130);
            this.remindertextBox3.Multiline = true;
            this.remindertextBox3.Name = "remindertextBox3";
            this.remindertextBox3.Size = new System.Drawing.Size(183, 22);
            this.remindertextBox3.TabIndex = 16;
            // 
            // remindertextBox4
            // 
            this.remindertextBox4.Location = new System.Drawing.Point(269, 166);
            this.remindertextBox4.Multiline = true;
            this.remindertextBox4.Name = "remindertextBox4";
            this.remindertextBox4.Size = new System.Drawing.Size(183, 22);
            this.remindertextBox4.TabIndex = 17;
            // 
            // remindertextBox5
            // 
            this.remindertextBox5.Location = new System.Drawing.Point(269, 203);
            this.remindertextBox5.Multiline = true;
            this.remindertextBox5.Name = "remindertextBox5";
            this.remindertextBox5.Size = new System.Drawing.Size(183, 22);
            this.remindertextBox5.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(80, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(161, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Stop";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(80, 129);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Start";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(161, 130);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 24;
            this.button6.Text = "Stop";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(80, 165);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 25;
            this.button7.Text = "Start";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(161, 166);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 26;
            this.button8.Text = "Stop";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(80, 202);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 27;
            this.button9.Text = "Start";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(161, 203);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 28;
            this.button10.Text = "Stop";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(223, 311);
            this.maskedTextBox1.Mask = "00:00:0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(147, 30);
            this.maskedTextBox1.TabIndex = 33;
            this.maskedTextBox1.Text = "12061998";
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox2.Location = new System.Drawing.Point(223, 383);
            this.maskedTextBox2.Mask = "00:00:0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(147, 30);
            this.maskedTextBox2.TabIndex = 32;
            this.maskedTextBox2.Text = "28122001";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox3.Location = new System.Drawing.Point(223, 419);
            this.maskedTextBox3.Mask = "00:00:0000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(147, 30);
            this.maskedTextBox3.TabIndex = 31;
            this.maskedTextBox3.Text = "18012000";
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox4.Location = new System.Drawing.Point(223, 347);
            this.maskedTextBox4.Mask = "00:00:0000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(147, 30);
            this.maskedTextBox4.TabIndex = 30;
            this.maskedTextBox4.Text = "25071995";
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox5.Location = new System.Drawing.Point(223, 275);
            this.maskedTextBox5.Mask = "00:00:0000";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(147, 30);
            this.maskedTextBox5.TabIndex = 29;
            this.maskedTextBox5.Text = "09031989";
            this.maskedTextBox5.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox5_MaskInputRejected);
            // 
            // remindertimer1
            // 
            this.remindertimer1.Interval = 500;
            this.remindertimer1.Tick += new System.EventHandler(this.remindertimer1_Tick);
            // 
            // remindertimer2
            // 
            this.remindertimer2.Interval = 500;
            this.remindertimer2.Tick += new System.EventHandler(this.remindertimer2_Tick);
            // 
            // remindertimer3
            // 
            this.remindertimer3.Interval = 500;
            this.remindertimer3.Tick += new System.EventHandler(this.remindertimer3_Tick);
            // 
            // remindertimer4
            // 
            this.remindertimer4.Interval = 500;
            this.remindertimer4.Tick += new System.EventHandler(this.remindertimer4_Tick);
            // 
            // remindertimer5
            // 
            this.remindertimer5.Interval = 500;
            this.remindertimer5.Tick += new System.EventHandler(this.remindertimer5_Tick);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.remindertextBox5);
            this.Controls.Add(this.remindertextBox4);
            this.Controls.Add(this.remindertextBox3);
            this.Controls.Add(this.remindertextBox2);
            this.Controls.Add(this.remindertextBox1);
            this.Controls.Add(this.remindermaskedTextBox5);
            this.Controls.Add(this.remindermaskedTextBox4);
            this.Controls.Add(this.remindermaskedTextBox3);
            this.Controls.Add(this.remindermaskedTextBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remindermaskedTextBox1);
            this.Controls.Add(this.realTimelabel);
            this.Name = "Mainform";
            this.Text = "Поздравлятор";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label realTimelabel;
        private System.Windows.Forms.Timer realTimetimer;
        private System.Windows.Forms.MaskedTextBox remindermaskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox remindermaskedTextBox2;
        private System.Windows.Forms.MaskedTextBox remindermaskedTextBox3;
        private System.Windows.Forms.MaskedTextBox remindermaskedTextBox4;
        private System.Windows.Forms.MaskedTextBox remindermaskedTextBox5;
        private System.Windows.Forms.TextBox remindertextBox1;
        private System.Windows.Forms.TextBox remindertextBox2;
        private System.Windows.Forms.TextBox remindertextBox3;
        private System.Windows.Forms.TextBox remindertextBox4;
        private System.Windows.Forms.TextBox remindertextBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.Timer remindertimer1;
        private System.Windows.Forms.Timer remindertimer2;
        private System.Windows.Forms.Timer remindertimer3;
        private System.Windows.Forms.Timer remindertimer4;
        private System.Windows.Forms.Timer remindertimer5;
    }
}

