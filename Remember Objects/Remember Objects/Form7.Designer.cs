namespace Remember_Objects
{
    partial class Form7
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PlayerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startNewRoundBtn = new System.Windows.Forms.Button();
            this.CloseGame = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerNameColumn,
            this.ScoreColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridView1.Location = new System.Drawing.Point(381, 174);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(702, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // PlayerNameColumn
            // 
            this.PlayerNameColumn.HeaderText = "Игрок";
            this.PlayerNameColumn.MinimumWidth = 10;
            this.PlayerNameColumn.Name = "PlayerNameColumn";
            this.PlayerNameColumn.Width = 200;
            // 
            // ScoreColumn
            // 
            this.ScoreColumn.HeaderText = "Очки";
            this.ScoreColumn.MinimumWidth = 10;
            this.ScoreColumn.Name = "ScoreColumn";
            this.ScoreColumn.Width = 200;
            // 
            // startNewRoundBtn
            // 
            this.startNewRoundBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startNewRoundBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.startNewRoundBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.startNewRoundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startNewRoundBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startNewRoundBtn.Image = ((System.Drawing.Image)(resources.GetObject("startNewRoundBtn.Image")));
            this.startNewRoundBtn.Location = new System.Drawing.Point(20, 603);
            this.startNewRoundBtn.Margin = new System.Windows.Forms.Padding(2);
            this.startNewRoundBtn.Name = "startNewRoundBtn";
            this.startNewRoundBtn.Size = new System.Drawing.Size(336, 163);
            this.startNewRoundBtn.TabIndex = 3;
            this.startNewRoundBtn.UseVisualStyleBackColor = true;
            this.startNewRoundBtn.Click += new System.EventHandler(this.startNewRoundBtn_Click);
            // 
            // CloseGame
            // 
            this.CloseGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.CloseGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CloseGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseGame.Image = ((System.Drawing.Image)(resources.GetObject("CloseGame.Image")));
            this.CloseGame.Location = new System.Drawing.Point(1032, 647);
            this.CloseGame.Margin = new System.Windows.Forms.Padding(2);
            this.CloseGame.Name = "CloseGame";
            this.CloseGame.Size = new System.Drawing.Size(328, 119);
            this.CloseGame.TabIndex = 4;
            this.CloseGame.UseVisualStyleBackColor = true;
            this.CloseGame.Click += new System.EventHandler(this.CloseGame_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox1.Location = new System.Drawing.Point(20, 68);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(607, 38);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox2.Location = new System.Drawing.Point(775, 68);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(607, 38);
            this.textBox2.TabIndex = 6;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1371, 777);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CloseGame);
            this.Controls.Add(this.startNewRoundBtn);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form7";
            this.Text = "Results";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button startNewRoundBtn;
        private System.Windows.Forms.Button CloseGame;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreColumn;
    }
}