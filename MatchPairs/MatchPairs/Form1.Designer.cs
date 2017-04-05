namespace MatchPairs
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
            this.components = new System.ComponentModel.Container();
            this.numericUpDown_row = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_column = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Create_button = new System.Windows.Forms.Button();
            this.label_count = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.user_radioButton = new System.Windows.Forms.RadioButton();
            this.userPictures_button = new System.Windows.Forms.Button();
            this.fruits_radioButton = new System.Windows.Forms.RadioButton();
            this.digits_radioButton = new System.Windows.Forms.RadioButton();
            this.space_radioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.timer_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stats_button = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_row)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_column)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_row
            // 
            this.numericUpDown_row.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_row.Location = new System.Drawing.Point(612, 226);
            this.numericUpDown_row.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown_row.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_row.Name = "numericUpDown_row";
            this.numericUpDown_row.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown_row.TabIndex = 1;
            this.numericUpDown_row.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numericUpDown_column
            // 
            this.numericUpDown_column.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_column.Location = new System.Drawing.Point(612, 251);
            this.numericUpDown_column.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown_column.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_column.Name = "numericUpDown_column";
            this.numericUpDown_column.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown_column.TabIndex = 2;
            this.numericUpDown_column.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Строк";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Столбцов";
            // 
            // Create_button
            // 
            this.Create_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Create_button.Location = new System.Drawing.Point(516, 282);
            this.Create_button.Name = "Create_button";
            this.Create_button.Size = new System.Drawing.Size(128, 33);
            this.Create_button.TabIndex = 5;
            this.Create_button.Text = "Применить";
            this.Create_button.UseVisualStyleBackColor = true;
            this.Create_button.Click += new System.EventHandler(this.Create_button_Click);
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(163, 21);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(13, 13);
            this.label_count.TabIndex = 7;
            this.label_count.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.user_radioButton);
            this.groupBox1.Controls.Add(this.userPictures_button);
            this.groupBox1.Controls.Add(this.fruits_radioButton);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.digits_radioButton);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.space_radioButton);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(510, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 195);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изображения";
            // 
            // user_radioButton
            // 
            this.user_radioButton.AutoSize = true;
            this.user_radioButton.Location = new System.Drawing.Point(6, 161);
            this.user_radioButton.Name = "user_radioButton";
            this.user_radioButton.Size = new System.Drawing.Size(50, 17);
            this.user_radioButton.TabIndex = 7;
            this.user_radioButton.Text = "Свои";
            this.user_radioButton.UseVisualStyleBackColor = true;
            // 
            // userPictures_button
            // 
            this.userPictures_button.Location = new System.Drawing.Point(89, 158);
            this.userPictures_button.Name = "userPictures_button";
            this.userPictures_button.Size = new System.Drawing.Size(32, 23);
            this.userPictures_button.TabIndex = 6;
            this.userPictures_button.Text = "...";
            this.userPictures_button.UseVisualStyleBackColor = true;
            this.userPictures_button.Click += new System.EventHandler(this.userPictures_button_Click);
            // 
            // fruits_radioButton
            // 
            this.fruits_radioButton.AutoSize = true;
            this.fruits_radioButton.Location = new System.Drawing.Point(6, 125);
            this.fruits_radioButton.Name = "fruits_radioButton";
            this.fruits_radioButton.Size = new System.Drawing.Size(66, 17);
            this.fruits_radioButton.TabIndex = 5;
            this.fruits_radioButton.Text = "Фрукты";
            this.fruits_radioButton.UseVisualStyleBackColor = true;
            // 
            // digits_radioButton
            // 
            this.digits_radioButton.AutoSize = true;
            this.digits_radioButton.Location = new System.Drawing.Point(6, 75);
            this.digits_radioButton.Name = "digits_radioButton";
            this.digits_radioButton.Size = new System.Drawing.Size(61, 17);
            this.digits_radioButton.TabIndex = 3;
            this.digits_radioButton.Text = "Цифры";
            this.digits_radioButton.UseVisualStyleBackColor = true;
            // 
            // space_radioButton
            // 
            this.space_radioButton.AutoSize = true;
            this.space_radioButton.Checked = true;
            this.space_radioButton.Location = new System.Drawing.Point(6, 29);
            this.space_radioButton.Name = "space_radioButton";
            this.space_radioButton.Size = new System.Drawing.Size(64, 17);
            this.space_radioButton.TabIndex = 1;
            this.space_radioButton.TabStop = true;
            this.space_radioButton.Text = "Космос";
            this.space_radioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(11, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 338);
            this.panel1.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Время:";
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Location = new System.Drawing.Point(57, 21);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(13, 13);
            this.timer_label.TabIndex = 11;
            this.timer_label.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ходы:";
            // 
            // stats_button
            // 
            this.stats_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stats_button.Location = new System.Drawing.Point(398, 9);
            this.stats_button.Name = "stats_button";
            this.stats_button.Size = new System.Drawing.Size(98, 22);
            this.stats_button.TabIndex = 13;
            this.stats_button.Text = "Статистика...";
            this.stats_button.UseVisualStyleBackColor = true;
            this.stats_button.Click += new System.EventHandler(this.stats_button_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "Space";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MatchPairs.Properties.Resources.банан;
            this.pictureBox3.Location = new System.Drawing.Point(72, 115);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MatchPairs.Properties.Resources._4;
            this.pictureBox2.Location = new System.Drawing.Point(72, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MatchPairs.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(72, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 399);
            this.Controls.Add(this.stats_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timer_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.Create_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_column);
            this.Controls.Add(this.numericUpDown_row);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_row)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_column)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown_row;
        private System.Windows.Forms.NumericUpDown numericUpDown_column;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Create_button;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button userPictures_button;
        private System.Windows.Forms.RadioButton fruits_radioButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton digits_radioButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton space_radioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button stats_button;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RadioButton user_radioButton;
    }
}

