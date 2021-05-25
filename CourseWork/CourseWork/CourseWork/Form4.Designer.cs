namespace CourseWork
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.repeatpasswordtextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openpassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("a_FuturaRound", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(193, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 55);
            this.label1.TabIndex = 10;
            this.label1.Text = "Регистрация";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("a_FuturaRound", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(28, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("a_FuturaRound", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(28, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "Повторите пароль:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("a_FuturaRound", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(28, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 37);
            this.label4.TabIndex = 13;
            this.label4.Text = "Пароль:";
            // 
            // nametextBox
            // 
            this.nametextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nametextBox.Font = new System.Drawing.Font("a_FuturaRound", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nametextBox.Location = new System.Drawing.Point(350, 123);
            this.nametextBox.MaxLength = 15;
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(279, 46);
            this.nametextBox.TabIndex = 14;
            this.nametextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nametextBox_KeyPress);
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordtextBox.Font = new System.Drawing.Font("a_FuturaRound", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordtextBox.Location = new System.Drawing.Point(350, 202);
            this.passwordtextBox.MaxLength = 15;
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(279, 46);
            this.passwordtextBox.TabIndex = 15;
            this.passwordtextBox.UseSystemPasswordChar = true;
            this.passwordtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordtextBox_KeyPress);
            // 
            // repeatpasswordtextBox
            // 
            this.repeatpasswordtextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.repeatpasswordtextBox.Font = new System.Drawing.Font("a_FuturaRound", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeatpasswordtextBox.Location = new System.Drawing.Point(350, 286);
            this.repeatpasswordtextBox.MaxLength = 15;
            this.repeatpasswordtextBox.Name = "repeatpasswordtextBox";
            this.repeatpasswordtextBox.Size = new System.Drawing.Size(279, 46);
            this.repeatpasswordtextBox.TabIndex = 16;
            this.repeatpasswordtextBox.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("a_FuturaRound", 9.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(62, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 67);
            this.button1.TabIndex = 17;
            this.button1.Text = "Сохранить данные";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("a_FuturaRound", 9.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(368, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 67);
            this.button2.TabIndex = 18;
            this.button2.Text = "Вернуться на главный экран";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openpassword
            // 
            this.openpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openpassword.BackColor = System.Drawing.Color.MidnightBlue;
            this.openpassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openpassword.Location = new System.Drawing.Point(635, 210);
            this.openpassword.Name = "openpassword";
            this.openpassword.Size = new System.Drawing.Size(30, 30);
            this.openpassword.TabIndex = 19;
            this.openpassword.UseVisualStyleBackColor = false;
            this.openpassword.Click += new System.EventHandler(this.openpassword_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(694, 480);
            this.Controls.Add(this.openpassword);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.repeatpasswordtextBox);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(716, 536);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.TextBox repeatpasswordtextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button openpassword;
    }
}