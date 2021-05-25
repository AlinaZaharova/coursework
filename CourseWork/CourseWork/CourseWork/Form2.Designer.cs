namespace CourseWork
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.balancelabel = new System.Windows.Forms.Label();
            this.betlabel = new System.Windows.Forms.Label();
            this.winlabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.attemptlabel = new System.Windows.Forms.Label();
            this.spin = new System.Windows.Forms.Button();
            this.setbet = new System.Windows.Forms.Button();
            this.engine1 = new System.Windows.Forms.Timer(this.components);
            this.engine2 = new System.Windows.Forms.Timer(this.components);
            this.engine3 = new System.Windows.Forms.Timer(this.components);
            this.stop1 = new System.Windows.Forms.Timer(this.components);
            this.stop2 = new System.Windows.Forms.Timer(this.components);
            this.stop3 = new System.Windows.Forms.Timer(this.components);
            this.gamestop = new System.Windows.Forms.Button();
            this.backtomainscreen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ImageLocation = "D:\\\\My papers\\\\CourseWork\\\\pictures\\\\fruit2.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(156, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.ImageLocation = "D:\\\\My papers\\\\CourseWork\\\\pictures\\\\fruit2.jpg";
            this.pictureBox2.Location = new System.Drawing.Point(456, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(228, 228);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.ImageLocation = "D:\\\\My papers\\\\CourseWork\\\\pictures\\\\fruit2.jpg";
            this.pictureBox3.Location = new System.Drawing.Point(765, 57);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(228, 228);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // balancelabel
            // 
            this.balancelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.balancelabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.balancelabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.balancelabel.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balancelabel.Location = new System.Drawing.Point(53, 329);
            this.balancelabel.Name = "balancelabel";
            this.balancelabel.Size = new System.Drawing.Size(432, 58);
            this.balancelabel.TabIndex = 3;
            this.balancelabel.Text = "Баланс: $ 100";
            // 
            // betlabel
            // 
            this.betlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.betlabel.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.betlabel.Location = new System.Drawing.Point(44, 416);
            this.betlabel.Name = "betlabel";
            this.betlabel.Size = new System.Drawing.Size(175, 49);
            this.betlabel.TabIndex = 4;
            this.betlabel.Text = "Ставка:";
            // 
            // winlabel
            // 
            this.winlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.winlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.winlabel.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winlabel.Location = new System.Drawing.Point(53, 504);
            this.winlabel.Name = "winlabel";
            this.winlabel.Size = new System.Drawing.Size(432, 55);
            this.winlabel.TabIndex = 5;
            this.winlabel.Text = "Выигрыш: $ 0";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(209, 418);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(92, 51);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // attemptlabel
            // 
            this.attemptlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attemptlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.attemptlabel.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attemptlabel.Location = new System.Drawing.Point(53, 592);
            this.attemptlabel.Name = "attemptlabel";
            this.attemptlabel.Size = new System.Drawing.Size(432, 55);
            this.attemptlabel.TabIndex = 8;
            this.attemptlabel.Text = "Осталось попыток: ";
            // 
            // spin
            // 
            this.spin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spin.BackColor = System.Drawing.Color.DarkCyan;
            this.spin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.spin.Font = new System.Drawing.Font("Constantia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spin.ForeColor = System.Drawing.Color.Aquamarine;
            this.spin.Location = new System.Drawing.Point(810, 351);
            this.spin.Name = "spin";
            this.spin.Size = new System.Drawing.Size(158, 114);
            this.spin.TabIndex = 9;
            this.spin.Text = "Спин";
            this.spin.UseVisualStyleBackColor = false;
            this.spin.Click += new System.EventHandler(this.spin_Click);
            // 
            // setbet
            // 
            this.setbet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setbet.BackColor = System.Drawing.Color.DarkCyan;
            this.setbet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setbet.Font = new System.Drawing.Font("Constantia", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setbet.ForeColor = System.Drawing.Color.Aquamarine;
            this.setbet.Location = new System.Drawing.Point(330, 406);
            this.setbet.Name = "setbet";
            this.setbet.Size = new System.Drawing.Size(155, 80);
            this.setbet.TabIndex = 10;
            this.setbet.Text = "Сделать ставку";
            this.setbet.UseVisualStyleBackColor = false;
            this.setbet.Click += new System.EventHandler(this.setbet_Click);
            // 
            // engine1
            // 
            this.engine1.Interval = 60;
            this.engine1.Tick += new System.EventHandler(this.engine1_Tick);
            // 
            // engine2
            // 
            this.engine2.Interval = 60;
            this.engine2.Tick += new System.EventHandler(this.engine2_Tick);
            // 
            // engine3
            // 
            this.engine3.Interval = 60;
            this.engine3.Tick += new System.EventHandler(this.engine3_Tick);
            // 
            // stop1
            // 
            this.stop1.Interval = 1500;
            this.stop1.Tick += new System.EventHandler(this.stop1_Tick);
            // 
            // stop2
            // 
            this.stop2.Interval = 2500;
            this.stop2.Tick += new System.EventHandler(this.stop2_Tick);
            // 
            // stop3
            // 
            this.stop3.Interval = 3000;
            this.stop3.Tick += new System.EventHandler(this.stop3_Tick);
            // 
            // gamestop
            // 
            this.gamestop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gamestop.BackColor = System.Drawing.Color.DarkCyan;
            this.gamestop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gamestop.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamestop.ForeColor = System.Drawing.Color.Aquamarine;
            this.gamestop.Location = new System.Drawing.Point(535, 582);
            this.gamestop.Name = "gamestop";
            this.gamestop.Size = new System.Drawing.Size(269, 52);
            this.gamestop.TabIndex = 11;
            this.gamestop.Text = "Завершить игру";
            this.gamestop.UseVisualStyleBackColor = false;
            this.gamestop.Click += new System.EventHandler(this.gamestop_Click);
            // 
            // backtomainscreen
            // 
            this.backtomainscreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backtomainscreen.BackColor = System.Drawing.Color.DarkCyan;
            this.backtomainscreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backtomainscreen.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backtomainscreen.ForeColor = System.Drawing.Color.Aquamarine;
            this.backtomainscreen.Location = new System.Drawing.Point(836, 575);
            this.backtomainscreen.Name = "backtomainscreen";
            this.backtomainscreen.Size = new System.Drawing.Size(275, 72);
            this.backtomainscreen.TabIndex = 12;
            this.backtomainscreen.Text = "Вернуться на главный экран";
            this.backtomainscreen.UseVisualStyleBackColor = false;
            this.backtomainscreen.Click += new System.EventHandler(this.backtomainscreen_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1143, 676);
            this.Controls.Add(this.backtomainscreen);
            this.Controls.Add(this.gamestop);
            this.Controls.Add(this.setbet);
            this.Controls.Add(this.spin);
            this.Controls.Add(this.attemptlabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.winlabel);
            this.Controls.Add(this.betlabel);
            this.Controls.Add(this.balancelabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(1165, 732);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label balancelabel;
        private System.Windows.Forms.Label betlabel;
        private System.Windows.Forms.Label winlabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label attemptlabel;
        private System.Windows.Forms.Button spin;
        private System.Windows.Forms.Button setbet;
        private System.Windows.Forms.Timer engine1;
        private System.Windows.Forms.Timer engine2;
        private System.Windows.Forms.Timer engine3;
        private System.Windows.Forms.Timer stop1;
        private System.Windows.Forms.Timer stop2;
        private System.Windows.Forms.Timer stop3;
        private System.Windows.Forms.Button gamestop;
        private System.Windows.Forms.Button backtomainscreen;
    }
}