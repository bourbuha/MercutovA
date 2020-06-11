namespace Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.Label();
            this.AnumUpDown = new System.Windows.Forms.NumericUpDown();
            this.BnumUpDown = new System.Windows.Forms.NumericUpDown();
            this.NnumUpDown = new System.Windows.Forms.NumericUpDown();
            this.AnswerTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Choice = new System.Windows.Forms.Button();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AnumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BnumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NnumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "a=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "b=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество отрезков=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ответ=";
            // 
            // Comment
            // 
            this.Comment.AutoSize = true;
            this.Comment.Location = new System.Drawing.Point(20, 175);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(16, 17);
            this.Comment.TabIndex = 4;
            this.Comment.Text = "//";
            // 
            // AnumUpDown
            // 
            this.AnumUpDown.Location = new System.Drawing.Point(62, 50);
            this.AnumUpDown.Name = "AnumUpDown";
            this.AnumUpDown.Size = new System.Drawing.Size(120, 22);
            this.AnumUpDown.TabIndex = 5;
            // 
            // BnumUpDown
            // 
            this.BnumUpDown.Location = new System.Drawing.Point(62, 85);
            this.BnumUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.BnumUpDown.Name = "BnumUpDown";
            this.BnumUpDown.Size = new System.Drawing.Size(120, 22);
            this.BnumUpDown.TabIndex = 6;
            this.BnumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NnumUpDown
            // 
            this.NnumUpDown.Location = new System.Drawing.Point(184, 110);
            this.NnumUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NnumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NnumUpDown.Name = "NnumUpDown";
            this.NnumUpDown.Size = new System.Drawing.Size(120, 22);
            this.NnumUpDown.TabIndex = 7;
            this.NnumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AnswerTB
            // 
            this.AnswerTB.Enabled = false;
            this.AnswerTB.Location = new System.Drawing.Point(82, 141);
            this.AnswerTB.Name = "AnswerTB";
            this.AnswerTB.Size = new System.Drawing.Size(100, 22);
            this.AnswerTB.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Send_Click);
            // 
            // Choice
            // 
            this.Choice.Location = new System.Drawing.Point(388, 10);
            this.Choice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Choice.Name = "Choice";
            this.Choice.Size = new System.Drawing.Size(97, 23);
            this.Choice.TabIndex = 22;
            this.Choice.Text = "Ввод";
            this.Choice.UseVisualStyleBackColor = true;
            this.Choice.Click += new System.EventHandler(this.Choice_Click);
            // 
            // AddressTB
            // 
            this.AddressTB.Location = new System.Drawing.Point(62, 11);
            this.AddressTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddressTB.Multiline = true;
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(320, 22);
            this.AddressTB.TabIndex = 21;
            this.AddressTB.TabStop = false;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(3, 13);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(56, 17);
            this.Address.TabIndex = 20;
            this.Address.Text = "Aдрес :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "(x - 5 * Math.Pow(Math.Sin(x), 2))";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 203);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Choice);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AnswerTB);
            this.Controls.Add(this.NnumUpDown);
            this.Controls.Add(this.BnumUpDown);
            this.Controls.Add(this.AnumUpDown);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AnumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BnumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NnumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Comment;
        private System.Windows.Forms.NumericUpDown AnumUpDown;
        private System.Windows.Forms.NumericUpDown BnumUpDown;
        private System.Windows.Forms.NumericUpDown NnumUpDown;
        private System.Windows.Forms.TextBox AnswerTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Choice;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label label5;
    }
}

