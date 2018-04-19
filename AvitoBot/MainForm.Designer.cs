namespace AvitoBot
{
	partial class MainForm
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
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.buttonNavigateToAvito = new System.Windows.Forms.Button();
			this.buttonNavigateToLoginForm = new System.Windows.Forms.Button();
			this.buttonFill = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// webBrowser1
			// 
			this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.webBrowser1.Location = new System.Drawing.Point(12, 12);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(581, 479);
			this.webBrowser1.TabIndex = 0;
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxLogin.Location = new System.Drawing.Point(600, 141);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(245, 20);
			this.textBoxLogin.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(600, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(245, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Логин";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(600, 164);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(245, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Пароль";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPassword.Location = new System.Drawing.Point(600, 190);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(245, 20);
			this.textBoxPassword.TabIndex = 3;
			// 
			// buttonLogin
			// 
			this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLogin.Location = new System.Drawing.Point(600, 276);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(245, 47);
			this.buttonLogin.TabIndex = 5;
			this.buttonLogin.Text = "Войти";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// buttonNavigateToAvito
			// 
			this.buttonNavigateToAvito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonNavigateToAvito.Location = new System.Drawing.Point(600, 12);
			this.buttonNavigateToAvito.Name = "buttonNavigateToAvito";
			this.buttonNavigateToAvito.Size = new System.Drawing.Size(245, 47);
			this.buttonNavigateToAvito.TabIndex = 6;
			this.buttonNavigateToAvito.Text = "Перейти на Avito";
			this.buttonNavigateToAvito.UseVisualStyleBackColor = true;
			this.buttonNavigateToAvito.Click += new System.EventHandler(this.buttonNavigateToAvito_Click);
			// 
			// buttonNavigateToLoginForm
			// 
			this.buttonNavigateToLoginForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonNavigateToLoginForm.Location = new System.Drawing.Point(600, 65);
			this.buttonNavigateToLoginForm.Name = "buttonNavigateToLoginForm";
			this.buttonNavigateToLoginForm.Size = new System.Drawing.Size(245, 47);
			this.buttonNavigateToLoginForm.TabIndex = 7;
			this.buttonNavigateToLoginForm.Text = "Перейти на страницу авторизации";
			this.buttonNavigateToLoginForm.UseVisualStyleBackColor = true;
			this.buttonNavigateToLoginForm.Click += new System.EventHandler(this.buttonNavigateToLoginForm_Click);
			// 
			// buttonFill
			// 
			this.buttonFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonFill.Location = new System.Drawing.Point(600, 223);
			this.buttonFill.Name = "buttonFill";
			this.buttonFill.Size = new System.Drawing.Size(245, 47);
			this.buttonFill.TabIndex = 8;
			this.buttonFill.Text = "Заполнить";
			this.buttonFill.UseVisualStyleBackColor = true;
			this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(857, 503);
			this.Controls.Add(this.buttonFill);
			this.Controls.Add(this.buttonNavigateToLoginForm);
			this.Controls.Add(this.buttonNavigateToAvito);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxLogin);
			this.Controls.Add(this.webBrowser1);
			this.Name = "MainForm";
			this.Text = "Avito Bot";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.TextBox textBoxLogin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonNavigateToAvito;
		private System.Windows.Forms.Button buttonNavigateToLoginForm;
		private System.Windows.Forms.Button buttonFill;
	}
}

