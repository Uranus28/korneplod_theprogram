namespace Interface
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.LanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chineseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqrt_button = new System.Windows.Forms.Button();
            this.enternumber = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.input_textBox = new System.Windows.Forms.TextBox();
            this.output_textBox = new System.Windows.Forms.TextBox();
            this.accuracy_label = new System.Windows.Forms.Label();
            this.analitical_b = new System.Windows.Forms.RadioButton();
            this.arifmetical_b = new System.Windows.Forms.RadioButton();
            this.Accuracy = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.inputim_textBox = new System.Windows.Forms.TextBox();
            this.img_num = new System.Windows.Forms.Label();
            this.num_r = new System.Windows.Forms.RadioButton();
            this.cnum_r = new System.Windows.Forms.RadioButton();
            this.modes = new System.Windows.Forms.GroupBox();
            this.c_modes = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Accuracy)).BeginInit();
            this.modes.SuspendLayout();
            this.c_modes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LanguageToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(656, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // LanguageToolStripMenuItem
            // 
            this.LanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.russianToolStripMenuItem,
            this.englishToolStripMenuItem,
            this.chineseToolStripMenuItem});
            this.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem";
            this.LanguageToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.LanguageToolStripMenuItem.Text = "Language";
            this.LanguageToolStripMenuItem.Click += new System.EventHandler(this.языкToolStripMenuItem_Click);
            // 
            // russianToolStripMenuItem
            // 
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            this.russianToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.russianToolStripMenuItem.Text = "Russian";
            this.russianToolStripMenuItem.Click += new System.EventHandler(this.russianToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // chineseToolStripMenuItem
            // 
            this.chineseToolStripMenuItem.Name = "chineseToolStripMenuItem";
            this.chineseToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.chineseToolStripMenuItem.Text = "Chinese";
            this.chineseToolStripMenuItem.Click += new System.EventHandler(this.chineseToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // sqrt_button
            // 
            this.sqrt_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sqrt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqrt_button.Location = new System.Drawing.Point(22, 225);
            this.sqrt_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sqrt_button.Name = "sqrt_button";
            this.sqrt_button.Size = new System.Drawing.Size(608, 71);
            this.sqrt_button.TabIndex = 1;
            this.sqrt_button.Text = "Find sqrt";
            this.sqrt_button.UseVisualStyleBackColor = false;
            this.sqrt_button.Click += new System.EventHandler(this.sqrt_button_Click);
            // 
            // enternumber
            // 
            this.enternumber.AutoSize = true;
            this.enternumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enternumber.Location = new System.Drawing.Point(19, 121);
            this.enternumber.Name = "enternumber";
            this.enternumber.Size = new System.Drawing.Size(118, 20);
            this.enternumber.TabIndex = 2;
            this.enternumber.Text = "Enter Number:";
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer.Location = new System.Drawing.Point(19, 318);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(70, 20);
            this.answer.TabIndex = 3;
            this.answer.Text = "Answer:";
            // 
            // input_textBox
            // 
            this.input_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_textBox.Location = new System.Drawing.Point(24, 143);
            this.input_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.Size = new System.Drawing.Size(607, 24);
            this.input_textBox.TabIndex = 4;
            this.input_textBox.TextChanged += new System.EventHandler(this.input_textBox_TextChanged);
            // 
            // output_textBox
            // 
            this.output_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output_textBox.Location = new System.Drawing.Point(24, 351);
            this.output_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.output_textBox.Name = "output_textBox";
            this.output_textBox.ReadOnly = true;
            this.output_textBox.Size = new System.Drawing.Size(606, 24);
            this.output_textBox.TabIndex = 6;
            this.output_textBox.TextChanged += new System.EventHandler(this.output_textBox_TextChanged);
            // 
            // accuracy_label
            // 
            this.accuracy_label.AutoSize = true;
            this.accuracy_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accuracy_label.Location = new System.Drawing.Point(271, 393);
            this.accuracy_label.Name = "accuracy_label";
            this.accuracy_label.Size = new System.Drawing.Size(127, 25);
            this.accuracy_label.TabIndex = 8;
            this.accuracy_label.Text = "Accuracy: 0";
            // 
            // analitical_b
            // 
            this.analitical_b.AutoSize = true;
            this.analitical_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.analitical_b.Location = new System.Drawing.Point(11, 47);
            this.analitical_b.Name = "analitical_b";
            this.analitical_b.Size = new System.Drawing.Size(92, 20);
            this.analitical_b.TabIndex = 9;
            this.analitical_b.Text = "Analitical";
            this.analitical_b.UseVisualStyleBackColor = true;
            // 
            // arifmetical_b
            // 
            this.arifmetical_b.AutoSize = true;
            this.arifmetical_b.Checked = true;
            this.arifmetical_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arifmetical_b.Location = new System.Drawing.Point(11, 21);
            this.arifmetical_b.Name = "arifmetical_b";
            this.arifmetical_b.Size = new System.Drawing.Size(101, 20);
            this.arifmetical_b.TabIndex = 10;
            this.arifmetical_b.TabStop = true;
            this.arifmetical_b.Text = "Arifmetical";
            this.arifmetical_b.UseVisualStyleBackColor = true;
            this.arifmetical_b.CheckedChanged += new System.EventHandler(this.arifmetical_b_CheckedChanged);
            // 
            // Accuracy
            // 
            this.Accuracy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Accuracy.LargeChange = 1;
            this.Accuracy.Location = new System.Drawing.Point(22, 435);
            this.Accuracy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Accuracy.Maximum = 28;
            this.Accuracy.Name = "Accuracy";
            this.Accuracy.Size = new System.Drawing.Size(608, 56);
            this.Accuracy.TabIndex = 7;
            this.Accuracy.Scroll += new System.EventHandler(this.Accuracy_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(73, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(113, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(155, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(194, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(233, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(273, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "12";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(315, 457);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "14";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(354, 456);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "16";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(398, 457);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "18";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(437, 456);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 18);
            this.label13.TabIndex = 22;
            this.label13.Text = "20";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(478, 457);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "22";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(519, 456);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 18);
            this.label15.TabIndex = 24;
            this.label15.Text = "24";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(562, 457);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 16);
            this.label16.TabIndex = 25;
            this.label16.Text = "26";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(604, 455);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 18);
            this.label17.TabIndex = 26;
            this.label17.Text = "28";
            // 
            // inputim_textBox
            // 
            this.inputim_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputim_textBox.Location = new System.Drawing.Point(24, 193);
            this.inputim_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputim_textBox.Name = "inputim_textBox";
            this.inputim_textBox.Size = new System.Drawing.Size(607, 24);
            this.inputim_textBox.TabIndex = 27;
            this.inputim_textBox.Visible = false;
            this.inputim_textBox.TextChanged += new System.EventHandler(this.inputim_textBox_TextChanged);
            // 
            // img_num
            // 
            this.img_num.AutoSize = true;
            this.img_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.img_num.Location = new System.Drawing.Point(20, 169);
            this.img_num.Name = "img_num";
            this.img_num.Size = new System.Drawing.Size(195, 20);
            this.img_num.TabIndex = 28;
            this.img_num.Text = "Enter Imaginary Number:";
            this.img_num.Visible = false;
            // 
            // num_r
            // 
            this.num_r.AutoSize = true;
            this.num_r.Checked = true;
            this.num_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num_r.Location = new System.Drawing.Point(6, 22);
            this.num_r.Name = "num_r";
            this.num_r.Size = new System.Drawing.Size(82, 20);
            this.num_r.TabIndex = 31;
            this.num_r.TabStop = true;
            this.num_r.Text = "Number";
            this.num_r.UseVisualStyleBackColor = true;
            this.num_r.CheckedChanged += new System.EventHandler(this.num_r_CheckedChanged);
            // 
            // cnum_r
            // 
            this.cnum_r.AutoSize = true;
            this.cnum_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cnum_r.Location = new System.Drawing.Point(6, 48);
            this.cnum_r.Name = "cnum_r";
            this.cnum_r.Size = new System.Drawing.Size(146, 20);
            this.cnum_r.TabIndex = 30;
            this.cnum_r.Text = "Complex Number";
            this.cnum_r.UseVisualStyleBackColor = true;
            // 
            // modes
            // 
            this.modes.Controls.Add(this.arifmetical_b);
            this.modes.Controls.Add(this.analitical_b);
            this.modes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modes.Location = new System.Drawing.Point(35, 31);
            this.modes.Name = "modes";
            this.modes.Size = new System.Drawing.Size(200, 75);
            this.modes.TabIndex = 33;
            this.modes.TabStop = false;
            this.modes.Text = "Modes:";
            // 
            // c_modes
            // 
            this.c_modes.Controls.Add(this.num_r);
            this.c_modes.Controls.Add(this.cnum_r);
            this.c_modes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c_modes.Location = new System.Drawing.Point(428, 31);
            this.c_modes.Name = "c_modes";
            this.c_modes.Size = new System.Drawing.Size(200, 75);
            this.c_modes.TabIndex = 34;
            this.c_modes.TabStop = false;
            this.c_modes.Text = "Calc Modes:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 513);
            this.Controls.Add(this.c_modes);
            this.Controls.Add(this.modes);
            this.Controls.Add(this.img_num);
            this.Controls.Add(this.inputim_textBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accuracy_label);
            this.Controls.Add(this.Accuracy);
            this.Controls.Add(this.output_textBox);
            this.Controls.Add(this.input_textBox);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.enternumber);
            this.Controls.Add(this.sqrt_button);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "victorКОРНЕплод";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Accuracy)).EndInit();
            this.modes.ResumeLayout(false);
            this.modes.PerformLayout();
            this.c_modes.ResumeLayout(false);
            this.c_modes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem LanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Button sqrt_button;
        private System.Windows.Forms.Label enternumber;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.TextBox input_textBox;
        private System.Windows.Forms.TextBox output_textBox;
        private System.Windows.Forms.Label accuracy_label;
        private System.Windows.Forms.RadioButton analitical_b;
        private System.Windows.Forms.RadioButton arifmetical_b;
        private System.Windows.Forms.TrackBar Accuracy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chineseToolStripMenuItem;
        private System.Windows.Forms.TextBox inputim_textBox;
        private System.Windows.Forms.Label img_num;
        private System.Windows.Forms.RadioButton num_r;
        private System.Windows.Forms.RadioButton cnum_r;
        private System.Windows.Forms.GroupBox modes;
        private System.Windows.Forms.GroupBox c_modes;
    }
}

