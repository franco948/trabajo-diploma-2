﻿namespace ConsultorioDigital.UI.Formularios
{
  partial class LoginForm
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
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtContraseña = new System.Windows.Forms.TextBox();
      this.btnLogin = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(15, 25);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(100, 20);
      this.txtEmail.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(32, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Email";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 48);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(61, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Contraseña";
      // 
      // txtContraseña
      // 
      this.txtContraseña.Location = new System.Drawing.Point(15, 64);
      this.txtContraseña.Name = "txtContraseña";
      this.txtContraseña.PasswordChar = '*';
      this.txtContraseña.Size = new System.Drawing.Size(100, 20);
      this.txtContraseña.TabIndex = 2;
      // 
      // btnLogin
      // 
      this.btnLogin.Location = new System.Drawing.Point(15, 90);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(75, 23);
      this.btnLogin.TabIndex = 4;
      this.btnLogin.Text = "Login";
      this.btnLogin.UseVisualStyleBackColor = true;
      this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(262, 126);
      this.Controls.Add(this.btnLogin);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtContraseña);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtEmail);
      this.Name = "LoginForm";
      this.Text = "Login";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtContraseña;
    private System.Windows.Forms.Button btnLogin;
  }
}