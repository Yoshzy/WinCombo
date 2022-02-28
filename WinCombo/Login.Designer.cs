namespace WinCombo
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.nomebox = new System.Windows.Forms.TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.senhabox = new System.Windows.Forms.TextBox();
            this.loginbt = new FontAwesome.Sharp.IconButton();
            this.exitlogin = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkinfo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(146, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 93);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(73, 180);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // nomebox
            // 
            this.nomebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomebox.Location = new System.Drawing.Point(111, 186);
            this.nomebox.Name = "nomebox";
            this.nomebox.Size = new System.Drawing.Size(178, 26);
            this.nomebox.TabIndex = 2;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(73, 240);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 3;
            this.iconPictureBox2.TabStop = false;
            // 
            // senhabox
            // 
            this.senhabox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhabox.Location = new System.Drawing.Point(111, 245);
            this.senhabox.Name = "senhabox";
            this.senhabox.PasswordChar = '*';
            this.senhabox.Size = new System.Drawing.Size(178, 26);
            this.senhabox.TabIndex = 4;
            // 
            // loginbt
            // 
            this.loginbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(62)))), ((int)(((byte)(250)))));
            this.loginbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbt.ForeColor = System.Drawing.Color.White;
            this.loginbt.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.loginbt.IconColor = System.Drawing.Color.White;
            this.loginbt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.loginbt.IconSize = 30;
            this.loginbt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginbt.Location = new System.Drawing.Point(39, 337);
            this.loginbt.Name = "loginbt";
            this.loginbt.Size = new System.Drawing.Size(125, 46);
            this.loginbt.TabIndex = 5;
            this.loginbt.Text = "Login";
            this.loginbt.UseVisualStyleBackColor = false;
            this.loginbt.Click += new System.EventHandler(this.loginbt_Click);
            // 
            // exitlogin
            // 
            this.exitlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(62)))), ((int)(((byte)(250)))));
            this.exitlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitlogin.ForeColor = System.Drawing.Color.White;
            this.exitlogin.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.exitlogin.IconColor = System.Drawing.Color.White;
            this.exitlogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitlogin.IconSize = 30;
            this.exitlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitlogin.Location = new System.Drawing.Point(206, 337);
            this.exitlogin.Name = "exitlogin";
            this.exitlogin.Size = new System.Drawing.Size(125, 46);
            this.exitlogin.TabIndex = 6;
            this.exitlogin.Text = "Sair";
            this.exitlogin.UseVisualStyleBackColor = false;
            this.exitlogin.Click += new System.EventHandler(this.exitlogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Senha:";
            // 
            // checkinfo
            // 
            this.checkinfo.AutoSize = true;
            this.checkinfo.Location = new System.Drawing.Point(125, 296);
            this.checkinfo.Name = "checkinfo";
            this.checkinfo.Size = new System.Drawing.Size(143, 17);
            this.checkinfo.TabIndex = 9;
            this.checkinfo.Text = "Salvar nome de usuário?";
            this.checkinfo.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(370, 462);
            this.ControlBox = false;
            this.Controls.Add(this.checkinfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitlogin);
            this.Controls.Add(this.loginbt);
            this.Controls.Add(this.senhabox);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.nomebox);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox nomebox;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.TextBox senhabox;
        private FontAwesome.Sharp.IconButton loginbt;
        private FontAwesome.Sharp.IconButton exitlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkinfo;
    }
}