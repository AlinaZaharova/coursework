namespace CourseWork
{
    partial class Authorization
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
            this.openpassword1 = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.registr = new System.Windows.Forms.Button();
            this.passwordtextBox1 = new System.Windows.Forms.TextBox();
            this.nametextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openpassword1
            // 
            this.openpassword1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openpassword1.BackColor = System.Drawing.Color.MidnightBlue;
            this.openpassword1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openpassword1.Location = new System.Drawing.Point(642, 240);
            this.openpassword1.Name = "openpassword1";
            this.openpassword1.Size = new System.Drawing.Size(30, 30);
            this.openpassword1.TabIndex = 29;
            this.openpassword1.UseVisualStyleBackColor = false;
            this.openpassword1.Click += new System.EventHandler(this.openpassword1_Click);
            // 
            // confirm
            // 
            this.confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirm.BackColor = System.Drawing.Color.MidnightBlue;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirm.Font = new System.Drawing.Font("a_FuturaRound", 9.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirm.ForeColor = System.Drawing.Color.White;
            this.confirm.Location = new System.Drawing.Point(357, 341);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(242, 60);
            this.confirm.TabIndex = 28;
            this.confirm.Text = "Подтвердить данные";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // registr
            // 
            this.registr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registr.BackColor = System.Drawing.Color.MidnightBlue;
            this.registr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registr.Font = new System.Drawing.Font("a_FuturaRound", 9.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registr.ForeColor = System.Drawing.Color.White;
            this.registr.Location = new System.Drawing.Point(72, 341);
            this.registr.Name = "registr";
            this.registr.Size = new System.Drawing.Size(231, 60);
            this.registr.TabIndex = 27;
            this.registr.Text = "Зарегистрироваться";
            this.registr.UseVisualStyleBackColor = false;
            this.registr.Click += new System.EventHandler(this.Registr_Click);
            // 
            // passwordtextBox1
            // 
            this.passwordtextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordtextBox1.Font = new System.Drawing.Font("a_FuturaRound", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordtextBox1.Location = new System.Drawing.Point(357, 232);
            this.passwordtextBox1.MaxLength = 15;
            this.passwordtextBox1.Name = "passwordtextBox1";
            this.passwordtextBox1.Size = new System.Drawing.Size(279, 46);
            this.passwordtextBox1.TabIndex = 25;
            this.passwordtextBox1.UseSystemPasswordChar = true;
            this.passwordtextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordtextBox1_KeyPress);
            // 
            // nametextBox1
            // 
            this.nametextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nametextBox1.Font = new System.Drawing.Font("a_FuturaRound", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nametextBox1.Location = new System.Drawing.Point(357, 153);
            this.nametextBox1.MaxLength = 15;
            this.nametextBox1.Name = "nametextBox1";
            this.nametextBox1.Size = new System.Drawing.Size(279, 46);
            this.nametextBox1.TabIndex = 24;
            this.nametextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nametextBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("a_FuturaRound", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(59, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 37);
            this.label4.TabIndex = 23;
            this.label4.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("a_FuturaRound", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(59, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 37);
            this.label2.TabIndex = 21;
            this.label2.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("a_FuturaRound", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(198, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 55);
            this.label1.TabIndex = 20;
            this.label1.Text = "Авторизация";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("a_FuturaRound", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(652, 27);
            this.label3.TabIndex = 30;
            this.label3.Text = "Чтобы начать игру, вам необходимо авторизироваться";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(694, 480);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.openpassword1);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.registr);
            this.Controls.Add(this.passwordtextBox1);
            this.Controls.Add(this.nametextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(716, 536);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openpassword1;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button registr;
        private System.Windows.Forms.TextBox passwordtextBox1;
        private System.Windows.Forms.TextBox nametextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}