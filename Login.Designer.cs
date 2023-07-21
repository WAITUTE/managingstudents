namespace Engineeringmanagement2
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
            this.UseName = new System.Windows.Forms.Label();
            this.PassWord = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UseName
            // 
            this.UseName.AutoSize = true;
            this.UseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseName.Location = new System.Drawing.Point(226, 72);
            this.UseName.Name = "UseName";
            this.UseName.Size = new System.Drawing.Size(73, 16);
            this.UseName.TabIndex = 0;
            this.UseName.Text = "UserName";
            // 
            // PassWord
            // 
            this.PassWord.AutoSize = true;
            this.PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWord.Location = new System.Drawing.Point(228, 115);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(71, 16);
            this.PassWord.TabIndex = 1;
            this.PassWord.Text = "PassWord";
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(327, 72);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(141, 20);
            this.textUser.TabIndex = 2;
            this.textUser.TextChanged += new System.EventHandler(this.textUser_TextChanged);
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(327, 115);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(141, 20);
            this.textPass.TabIndex = 3;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(327, 214);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(141, 39);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "SignIn";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.UseName);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UseName;
        private System.Windows.Forms.Label PassWord;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button btnSignIn;
    }
}