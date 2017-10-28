namespace Login.View
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnEntry = new System.Windows.Forms.Button();
            this.linkLbForgot = new System.Windows.Forms.LinkLabel();
            this.linkLbRegister = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.LightGray;
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(36, 183);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(197, 22);
            this.tbLogin.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.LightGray;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(36, 228);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(197, 22);
            this.tbPassword.TabIndex = 1;
            // 
            // btnEntry
            // 
            this.btnEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEntry.Location = new System.Drawing.Point(92, 265);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(75, 23);
            this.btnEntry.TabIndex = 2;
            this.btnEntry.Text = "Вход";
            this.btnEntry.UseVisualStyleBackColor = true;
            // 
            // linkLbForgot
            // 
            this.linkLbForgot.AutoSize = true;
            this.linkLbForgot.BackColor = System.Drawing.Color.Transparent;
            this.linkLbForgot.Location = new System.Drawing.Point(12, 328);
            this.linkLbForgot.Name = "linkLbForgot";
            this.linkLbForgot.Size = new System.Drawing.Size(79, 13);
            this.linkLbForgot.TabIndex = 3;
            this.linkLbForgot.TabStop = true;
            this.linkLbForgot.Text = "Забыл пароь?";
            // 
            // linkLbRegister
            // 
            this.linkLbRegister.AutoSize = true;
            this.linkLbRegister.BackColor = System.Drawing.Color.Transparent;
            this.linkLbRegister.Location = new System.Drawing.Point(179, 328);
            this.linkLbRegister.Name = "linkLbRegister";
            this.linkLbRegister.Size = new System.Drawing.Size(72, 13);
            this.linkLbRegister.TabIndex = 4;
            this.linkLbRegister.TabStop = true;
            this.linkLbRegister.Text = "Регистрация";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(263, 350);
            this.Controls.Add(this.linkLbRegister);
            this.Controls.Add(this.linkLbForgot);
            this.Controls.Add(this.btnEntry);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(279, 389);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(279, 389);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.LinkLabel linkLbForgot;
        private System.Windows.Forms.LinkLabel linkLbRegister;
    }
}

