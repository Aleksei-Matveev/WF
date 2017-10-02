namespace Authorization
{
    partial class AutorizForm
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
        /// 

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorizForm));
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lLForgotPassword = new System.Windows.Forms.LinkLabel();
            this.lLRegister = new System.Windows.Forms.LinkLabel();
            this.pBLogin = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tbError = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbPassword.Location = new System.Drawing.Point(64, 200);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(166, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLogin.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbLogin.Location = new System.Drawing.Point(64, 174);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(166, 20);
            this.tbLogin.TabIndex = 0;
            // 
            // lLForgotPassword
            // 
            this.lLForgotPassword.AutoSize = true;
            this.lLForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lLForgotPassword.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLForgotPassword.Location = new System.Drawing.Point(12, 345);
            this.lLForgotPassword.Name = "lLForgotPassword";
            this.lLForgotPassword.Size = new System.Drawing.Size(78, 15);
            this.lLForgotPassword.TabIndex = 2;
            this.lLForgotPassword.TabStop = true;
            this.lLForgotPassword.Text = "Забыли пароль?";
            this.lLForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLForgotPassword_LinkClicked);
            // 
            // lLRegister
            // 
            this.lLRegister.AutoSize = true;
            this.lLRegister.BackColor = System.Drawing.Color.Transparent;
            this.lLRegister.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLRegister.Location = new System.Drawing.Point(201, 345);
            this.lLRegister.Name = "lLRegister";
            this.lLRegister.Size = new System.Drawing.Size(65, 15);
            this.lLRegister.TabIndex = 3;
            this.lLRegister.TabStop = true;
            this.lLRegister.Text = "Регистрация";
            this.lLRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLRegister_LinkClicked);
            // 
            // pBLogin
            // 
            this.pBLogin.BackColor = System.Drawing.Color.Transparent;
            this.pBLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBLogin.Image = ((System.Drawing.Image)(resources.GetObject("pBLogin.Image")));
            this.pBLogin.InitialImage = ((System.Drawing.Image)(resources.GetObject("pBLogin.InitialImage")));
            this.pBLogin.Location = new System.Drawing.Point(69, 240);
            this.pBLogin.Name = "pBLogin";
            this.pBLogin.Size = new System.Drawing.Size(149, 57);
            this.pBLogin.TabIndex = 4;
            this.pBLogin.TabStop = false;
            this.pBLogin.Click += new System.EventHandler(this.PBLogin_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 303);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(261, 21);
            this.progressBar.TabIndex = 5;
            this.progressBar.Visible = false;
            // 
            // tbError
            // 
            this.tbError.BackColor = System.Drawing.Color.DarkSalmon;
            this.tbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbError.ForeColor = System.Drawing.Color.Maroon;
            this.tbError.Location = new System.Drawing.Point(12, 303);
            this.tbError.MinimumSize = new System.Drawing.Size(261, 22);
            this.tbError.Name = "tbError";
            this.tbError.ReadOnly = true;
            this.tbError.Size = new System.Drawing.Size(261, 22);
            this.tbError.TabIndex = 6;
            this.tbError.Text = "Проверьте введенные данные";
            this.tbError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbError.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AutorizForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(285, 378);
            this.Controls.Add(this.tbError);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pBLogin);
            this.Controls.Add(this.lLRegister);
            this.Controls.Add(this.lLForgotPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(301, 417);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(301, 417);
            this.Name = "AutorizForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация в системе";
            ((System.ComponentModel.ISupportInitialize)(this.pBLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.LinkLabel lLForgotPassword;
        private System.Windows.Forms.LinkLabel lLRegister;
        private System.Windows.Forms.PictureBox pBLogin;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox tbError;
        private System.Windows.Forms.Timer timer1;
    }
}

