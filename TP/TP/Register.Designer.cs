namespace TP
{
    partial class Register
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
            this.signUp = new System.Windows.Forms.Button();
            this.signIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // signUp
            // 
            this.signUp.Location = new System.Drawing.Point(313, 256);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(143, 30);
            this.signUp.TabIndex = 0;
            this.signUp.Text = "Sign up";
            this.signUp.UseVisualStyleBackColor = true;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // signIn
            // 
            this.signIn.Location = new System.Drawing.Point(344, 217);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(75, 23);
            this.signIn.TabIndex = 1;
            this.signIn.Text = "Sign in";
            this.signIn.UseVisualStyleBackColor = true;
            this.signIn.Click += new System.EventHandler(this.signIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(313, 175);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(143, 20);
            this.password_tb.TabIndex = 4;
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(313, 124);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(143, 20);
            this.username_tb.TabIndex = 5;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.signUp);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.Button signIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.TextBox username_tb;
    }
}