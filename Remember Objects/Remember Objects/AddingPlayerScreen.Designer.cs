namespace Remember_Objects
{
    partial class AddingPlayerScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingPlayerScreen));
            this.stopAddingButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stopAddingButton
            // 
            this.stopAddingButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stopAddingButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.stopAddingButton.FlatAppearance.BorderSize = 0;
            this.stopAddingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.stopAddingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.stopAddingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopAddingButton.Image = ((System.Drawing.Image)(resources.GetObject("stopAddingButton.Image")));
            this.stopAddingButton.Location = new System.Drawing.Point(2032, 1196);
            this.stopAddingButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopAddingButton.Name = "stopAddingButton";
            this.stopAddingButton.Size = new System.Drawing.Size(692, 277);
            this.stopAddingButton.TabIndex = 0;
            this.stopAddingButton.UseVisualStyleBackColor = false;
            this.stopAddingButton.Click += new System.EventHandler(this.AddingButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(480, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1734, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AddingPlayerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(2746, 1494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stopAddingButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddingPlayerScreen";
            this.Text = "Adding Player";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stopAddingButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}