namespace secondLab_1ex
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Поезд = new Label();
            tAHBox = new TextBox();
            tAMBox = new TextBox();
            tDHBox = new TextBox();
            tDMBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            hMBox = new TextBox();
            hHBox = new TextBox();
            label8 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Поезд
            // 
            Поезд.AutoSize = true;
            Поезд.Location = new Point(102, 25);
            Поезд.Name = "Поезд";
            Поезд.Size = new Size(40, 15);
            Поезд.TabIndex = 0;
            Поезд.Text = "Поезд";
            // 
            // tAHBox
            // 
            tAHBox.Location = new Point(81, 58);
            tAHBox.Name = "tAHBox";
            tAHBox.Size = new Size(40, 23);
            tAHBox.TabIndex = 1;
            tAHBox.TextChanged += tAHBox_TextChanged;
            // 
            // tAMBox
            // 
            tAMBox.Location = new Point(127, 58);
            tAMBox.Name = "tAMBox";
            tAMBox.Size = new Size(40, 23);
            tAMBox.TabIndex = 2;
            tAMBox.TextChanged += tAMBox_TextChanged;
            // 
            // tDHBox
            // 
            tDHBox.Location = new Point(81, 87);
            tDHBox.Name = "tDHBox";
            tDHBox.Size = new Size(40, 23);
            tDHBox.TabIndex = 3;
            // 
            // tDMBox
            // 
            tDMBox.Location = new Point(127, 87);
            tDMBox.Name = "tDMBox";
            tDMBox.Size = new Size(40, 23);
            tDMBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 61);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 5;
            label1.Text = "Прибытие";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 40);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Часы";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 40);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 7;
            label3.Text = "Мин";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 90);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 8;
            label4.Text = "Отбытие";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(275, 25);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 9;
            label5.Text = "Пассажир";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(310, 40);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 13;
            label6.Text = "Мин";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(264, 40);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 12;
            label7.Text = "Часы";
            // 
            // hMBox
            // 
            hMBox.Location = new Point(310, 58);
            hMBox.Name = "hMBox";
            hMBox.Size = new Size(40, 23);
            hMBox.TabIndex = 11;
            // 
            // hHBox
            // 
            hHBox.Location = new Point(264, 58);
            hHBox.Name = "hHBox";
            hHBox.Size = new Size(40, 23);
            hHBox.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(194, 61);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 14;
            label8.Text = "Прибытие";
            // 
            // button1
            // 
            button1.Location = new Point(264, 126);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 15;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(hMBox);
            Controls.Add(hHBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tDMBox);
            Controls.Add(tDHBox);
            Controls.Add(tAMBox);
            Controls.Add(tAHBox);
            Controls.Add(Поезд);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Поезд;
        private TextBox tAHBox;
        private TextBox tAMBox;
        private TextBox tDHBox;
        private TextBox tDMBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox hMBox;
        private TextBox hHBox;
        private Label label8;
        private Button button1;
    }
}
