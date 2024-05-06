namespace Remember_Objects
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.createGameButton = new System.Windows.Forms.Button();
            this.countPlayerTextBox = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.countPlayerTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // createGameButton
            // 
            this.createGameButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.createGameButton.FlatAppearance.BorderSize = 0;
            this.createGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.createGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.createGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createGameButton.Image = ((System.Drawing.Image)(resources.GetObject("createGameButton.Image")));
            this.createGameButton.Location = new System.Drawing.Point(494, 539);
            this.createGameButton.Name = "createGameButton";
            this.createGameButton.Size = new System.Drawing.Size(399, 172);
            this.createGameButton.TabIndex = 0;
            this.createGameButton.UseVisualStyleBackColor = false;
            this.createGameButton.Click += new System.EventHandler(this.createGameButton_Click);
            // 
            // countPlayerTextBox
            // 
            this.countPlayerTextBox.Font = new System.Drawing.Font("Candara", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countPlayerTextBox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.countPlayerTextBox.Location = new System.Drawing.Point(636, 410);
            this.countPlayerTextBox.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.countPlayerTextBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.countPlayerTextBox.Name = "countPlayerTextBox";
            this.countPlayerTextBox.Size = new System.Drawing.Size(119, 98);
            this.countPlayerTextBox.TabIndex = 3;
            this.countPlayerTextBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(245, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(925, 97);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(142, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1098, 183);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // StartScreen
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1376, 781);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.countPlayerTextBox);
            this.Controls.Add(this.createGameButton);
            this.Name = "StartScreen";
            this.Text = "Start Game";
            ((System.ComponentModel.ISupportInitialize)(this.countPlayerTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createGameButton;
        private System.Windows.Forms.NumericUpDown countPlayerTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

