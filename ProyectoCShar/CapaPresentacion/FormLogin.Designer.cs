namespace CapaPresentacion
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TxtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.BtnLogin = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.TxtContraseña = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(44, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Usuario";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(44, 149);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Contraseña";
            // 
            // TxtUsuario
            // 
            // 
            // 
            // 
            this.TxtUsuario.CustomButton.Image = null;
            this.TxtUsuario.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.TxtUsuario.CustomButton.Name = "";
            this.TxtUsuario.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtUsuario.CustomButton.TabIndex = 1;
            this.TxtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtUsuario.CustomButton.UseSelectable = true;
            this.TxtUsuario.CustomButton.Visible = false;
            this.TxtUsuario.Lines = new string[0];
            this.TxtUsuario.Location = new System.Drawing.Point(48, 107);
            this.TxtUsuario.MaxLength = 32767;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.PasswordChar = '\0';
            this.TxtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUsuario.SelectedText = "";
            this.TxtUsuario.SelectionLength = 0;
            this.TxtUsuario.SelectionStart = 0;
            this.TxtUsuario.ShortcutsEnabled = true;
            this.TxtUsuario.Size = new System.Drawing.Size(179, 25);
            this.TxtUsuario.TabIndex = 2;
            this.TxtUsuario.UseSelectable = true;
            this.TxtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Image = global::CapaPresentacion.Properties.Resources.login;
            this.BtnLogin.Location = new System.Drawing.Point(48, 219);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(79, 58);
            this.BtnLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.TabStop = false;
            this.BtnLogin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = global::CapaPresentacion.Properties.Resources.remove;
            this.BtnCerrar.Location = new System.Drawing.Point(148, 219);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(79, 58);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 7;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // TxtContraseña
            // 
            // 
            // 
            // 
            this.TxtContraseña.CustomButton.Image = null;
            this.TxtContraseña.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.TxtContraseña.CustomButton.Name = "";
            this.TxtContraseña.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtContraseña.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtContraseña.CustomButton.TabIndex = 1;
            this.TxtContraseña.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtContraseña.CustomButton.UseSelectable = true;
            this.TxtContraseña.CustomButton.Visible = false;
            this.TxtContraseña.Lines = new string[0];
            this.TxtContraseña.Location = new System.Drawing.Point(48, 171);
            this.TxtContraseña.MaxLength = 32767;
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtContraseña.SelectedText = "";
            this.TxtContraseña.SelectionLength = 0;
            this.TxtContraseña.SelectionStart = 0;
            this.TxtContraseña.ShortcutsEnabled = true;
            this.TxtContraseña.Size = new System.Drawing.Size(179, 25);
            this.TxtContraseña.TabIndex = 3;
            this.TxtContraseña.UseSelectable = true;
            this.TxtContraseña.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtContraseña.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.logo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackImage = global::CapaPresentacion.Properties.Resources.logo2;
            this.ClientSize = new System.Drawing.Size(305, 328);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Login";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TxtUsuario;
        private System.Windows.Forms.PictureBox BtnLogin;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private MetroFramework.Controls.MetroTextBox TxtContraseña;
    }
}