namespace WinCombo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.btnSobre = new FontAwesome.Sharp.IconButton();
            this.btncRelogin = new FontAwesome.Sharp.IconButton();
            this.btnConta = new FontAwesome.Sharp.IconButton();
            this.btnCofrinho = new FontAwesome.Sharp.IconButton();
            this.btnServicos = new FontAwesome.Sharp.IconButton();
            this.btnFaturas = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.sobretext = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.labelDash = new System.Windows.Forms.Label();
            this.panelDesk = new System.Windows.Forms.Panel();
            this.userPic = new WinCombo.CircularPictureBox();
            this.MenuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(235)))));
            this.MenuPanel.Controls.Add(this.btnSobre);
            this.MenuPanel.Controls.Add(this.btncRelogin);
            this.MenuPanel.Controls.Add(this.btnConta);
            this.MenuPanel.Controls.Add(this.btnCofrinho);
            this.MenuPanel.Controls.Add(this.btnServicos);
            this.MenuPanel.Controls.Add(this.btnFaturas);
            this.MenuPanel.Controls.Add(this.btnHome);
            this.MenuPanel.Controls.Add(this.panel1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 661);
            this.MenuPanel.TabIndex = 0;
            // 
            // btnSobre
            // 
            this.btnSobre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btnSobre.IconColor = System.Drawing.Color.White;
            this.btnSobre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSobre.IconSize = 30;
            this.btnSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobre.Location = new System.Drawing.Point(0, 309);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSobre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSobre.Size = new System.Drawing.Size(200, 38);
            this.btnSobre.TabIndex = 7;
            this.btnSobre.Tag = "Conta";
            this.btnSobre.Text = "      Sobre";
            this.btnSobre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btncRelogin
            // 
            this.btncRelogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btncRelogin.FlatAppearance.BorderSize = 0;
            this.btncRelogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncRelogin.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncRelogin.ForeColor = System.Drawing.Color.White;
            this.btncRelogin.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btncRelogin.IconColor = System.Drawing.Color.White;
            this.btncRelogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncRelogin.IconSize = 30;
            this.btncRelogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncRelogin.Location = new System.Drawing.Point(0, 623);
            this.btncRelogin.Name = "btncRelogin";
            this.btncRelogin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 15);
            this.btncRelogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btncRelogin.Size = new System.Drawing.Size(200, 38);
            this.btncRelogin.TabIndex = 6;
            this.btncRelogin.Tag = "    Sair";
            this.btncRelogin.Text = "       Sair";
            this.btncRelogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncRelogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncRelogin.UseVisualStyleBackColor = true;
            this.btncRelogin.Click += new System.EventHandler(this.btncRelogin_Click);
            // 
            // btnConta
            // 
            this.btnConta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConta.FlatAppearance.BorderSize = 0;
            this.btnConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConta.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConta.ForeColor = System.Drawing.Color.White;
            this.btnConta.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnConta.IconColor = System.Drawing.Color.White;
            this.btnConta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConta.IconSize = 30;
            this.btnConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConta.Location = new System.Drawing.Point(0, 271);
            this.btnConta.Name = "btnConta";
            this.btnConta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConta.Size = new System.Drawing.Size(200, 38);
            this.btnConta.TabIndex = 5;
            this.btnConta.Tag = "Conta";
            this.btnConta.Text = "      Conta";
            this.btnConta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConta.UseVisualStyleBackColor = true;
            this.btnConta.Click += new System.EventHandler(this.btnConta_Click);
            // 
            // btnCofrinho
            // 
            this.btnCofrinho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCofrinho.FlatAppearance.BorderSize = 0;
            this.btnCofrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCofrinho.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCofrinho.ForeColor = System.Drawing.Color.White;
            this.btnCofrinho.IconChar = FontAwesome.Sharp.IconChar.PiggyBank;
            this.btnCofrinho.IconColor = System.Drawing.Color.White;
            this.btnCofrinho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCofrinho.IconSize = 30;
            this.btnCofrinho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCofrinho.Location = new System.Drawing.Point(0, 233);
            this.btnCofrinho.Name = "btnCofrinho";
            this.btnCofrinho.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCofrinho.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCofrinho.Size = new System.Drawing.Size(200, 38);
            this.btnCofrinho.TabIndex = 4;
            this.btnCofrinho.Tag = "Cofrinho";
            this.btnCofrinho.Text = "      Cofrinho";
            this.btnCofrinho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCofrinho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCofrinho.UseVisualStyleBackColor = true;
            this.btnCofrinho.Click += new System.EventHandler(this.btnCofrinho_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServicos.FlatAppearance.BorderSize = 0;
            this.btnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicos.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicos.ForeColor = System.Drawing.Color.White;
            this.btnServicos.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.btnServicos.IconColor = System.Drawing.Color.White;
            this.btnServicos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnServicos.IconSize = 30;
            this.btnServicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicos.Location = new System.Drawing.Point(0, 195);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnServicos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnServicos.Size = new System.Drawing.Size(200, 38);
            this.btnServicos.TabIndex = 3;
            this.btnServicos.Tag = "Serviços";
            this.btnServicos.Text = "      Serviços";
            this.btnServicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServicos.UseVisualStyleBackColor = true;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // btnFaturas
            // 
            this.btnFaturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFaturas.FlatAppearance.BorderSize = 0;
            this.btnFaturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturas.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturas.ForeColor = System.Drawing.Color.White;
            this.btnFaturas.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnFaturas.IconColor = System.Drawing.Color.White;
            this.btnFaturas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFaturas.IconSize = 30;
            this.btnFaturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaturas.Location = new System.Drawing.Point(0, 157);
            this.btnFaturas.Name = "btnFaturas";
            this.btnFaturas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFaturas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFaturas.Size = new System.Drawing.Size(200, 38);
            this.btnFaturas.TabIndex = 2;
            this.btnFaturas.Tag = "Faturas";
            this.btnFaturas.Text = "      Faturas";
            this.btnFaturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFaturas.UseVisualStyleBackColor = true;
            this.btnFaturas.Click += new System.EventHandler(this.btnFaturas_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 30;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 119);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHome.Size = new System.Drawing.Size(200, 38);
            this.btnHome.TabIndex = 1;
            this.btnHome.Tag = "Home";
            this.btnHome.Text = "      Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 119);
            this.panel1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(235)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 45;
            this.iconPictureBox1.Location = new System.Drawing.Point(155, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(45, 45);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.White;
            this.titlePanel.Controls.Add(this.userPic);
            this.titlePanel.Controls.Add(this.sobretext);
            this.titlePanel.Controls.Add(this.userText);
            this.titlePanel.Controls.Add(this.btnMinimize);
            this.titlePanel.Controls.Add(this.btnExit);
            this.titlePanel.Controls.Add(this.labelDash);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(200, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1064, 60);
            this.titlePanel.TabIndex = 1;
            this.titlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.titlePanel_Paint);
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            // 
            // sobretext
            // 
            this.sobretext.AutoSize = true;
            this.sobretext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobretext.Location = new System.Drawing.Point(789, 27);
            this.sobretext.Name = "sobretext";
            this.sobretext.Size = new System.Drawing.Size(95, 18);
            this.sobretext.TabIndex = 7;
            this.sobretext.Text = "Sobrenome";
            // 
            // userText
            // 
            this.userText.AutoSize = true;
            this.userText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userText.Location = new System.Drawing.Point(730, 27);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(53, 18);
            this.userText.TabIndex = 6;
            this.userText.Text = "Nome";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(184)))), ((int)(((byte)(245)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 25;
            this.btnMinimize.Location = new System.Drawing.Point(982, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 29);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 25;
            this.btnExit.Location = new System.Drawing.Point(1023, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelDash
            // 
            this.labelDash.AutoSize = true;
            this.labelDash.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDash.Location = new System.Drawing.Point(16, 12);
            this.labelDash.Name = "labelDash";
            this.labelDash.Size = new System.Drawing.Size(158, 29);
            this.labelDash.TabIndex = 0;
            this.labelDash.Text = "Dashboard";
            // 
            // panelDesk
            // 
            this.panelDesk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelDesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesk.Location = new System.Drawing.Point(200, 60);
            this.panelDesk.MinimumSize = new System.Drawing.Size(793, 453);
            this.panelDesk.Name = "panelDesk";
            this.panelDesk.Size = new System.Drawing.Size(1064, 601);
            this.panelDesk.TabIndex = 2;
            this.panelDesk.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesk_Paint);
            // 
            // userPic
            // 
            this.userPic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.userPic.BorderColor = System.Drawing.Color.RoyalBlue;
            this.userPic.BorderColor2 = System.Drawing.Color.HotPink;
            this.userPic.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.userPic.BorderSize = 2;
            this.userPic.GradientAngle = 50F;
            this.userPic.Location = new System.Drawing.Point(665, 0);
            this.userPic.Name = "userPic";
            this.userPic.Size = new System.Drawing.Size(59, 59);
            this.userPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPic.TabIndex = 8;
            this.userPic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 661);
            this.Controls.Add(this.panelDesk);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinCombo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.MenuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel titlePanel;
        private FontAwesome.Sharp.IconButton btncRelogin;
        private FontAwesome.Sharp.IconButton btnConta;
        private FontAwesome.Sharp.IconButton btnCofrinho;
        private FontAwesome.Sharp.IconButton btnServicos;
        private FontAwesome.Sharp.IconButton btnFaturas;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDash;
        private System.Windows.Forms.Panel panelDesk;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private System.Windows.Forms.Label userText;
        private System.Windows.Forms.Label sobretext;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private CircularPictureBox userPic;
        private FontAwesome.Sharp.IconButton btnSobre;
    }
}

