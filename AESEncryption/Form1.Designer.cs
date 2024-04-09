
namespace AESEncryption
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonExit = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            textIP = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            textBoxDcryptPassword = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textBoxEncrypted = new System.Windows.Forms.TextBox();
            buttonDecrypt = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            textBoxDebug = new System.Windows.Forms.TextBox();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            button5 = new System.Windows.Forms.Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonExit
            // 
            buttonExit.Enabled = false;
            buttonExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonExit.Location = new System.Drawing.Point(449, 288);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new System.Drawing.Size(94, 29);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Receive";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textIP);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxDcryptPassword);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBoxEncrypted);
            groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox2.Location = new System.Drawing.Point(12, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(775, 229);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Decryption";
            // 
            // textIP
            // 
            textIP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textIP.Location = new System.Drawing.Point(9, 184);
            textIP.Name = "textIP";
            textIP.Size = new System.Drawing.Size(390, 27);
            textIP.TabIndex = 9;
            textIP.TextChanged += textIP_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(11, 161);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(123, 20);
            label6.TabIndex = 12;
            label6.Text = "Server IP Address";
            label6.Click += label6_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(568, 48);
            button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(115, 31);
            button3.TabIndex = 7;
            button3.Text = "Encrypted file";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(8, 93);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(268, 20);
            label3.TabIndex = 4;
            label3.Text = "Provide password to use for decryption";
            // 
            // textBoxDcryptPassword
            // 
            textBoxDcryptPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxDcryptPassword.Location = new System.Drawing.Point(8, 117);
            textBoxDcryptPassword.Name = "textBoxDcryptPassword";
            textBoxDcryptPassword.Size = new System.Drawing.Size(390, 27);
            textBoxDcryptPassword.TabIndex = 3;
            textBoxDcryptPassword.TextChanged += textBoxDcryptPassword_TextChanged;
            textBoxDcryptPassword.MouseDoubleClick += textBoxDcryptPassword_MouseDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(8, 25);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(201, 20);
            label4.TabIndex = 1;
            label4.Text = "Enter path file encrypted text";
            // 
            // textBoxEncrypted
            // 
            textBoxEncrypted.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxEncrypted.Location = new System.Drawing.Point(8, 48);
            textBoxEncrypted.Name = "textBoxEncrypted";
            textBoxEncrypted.Size = new System.Drawing.Size(523, 27);
            textBoxEncrypted.TabIndex = 0;
            textBoxEncrypted.TextChanged += textBoxEncrypted_TextChanged;
            textBoxEncrypted.MouseDoubleClick += textBoxEncrypted_MouseDoubleClick;
            // 
            // buttonDecrypt
            // 
            buttonDecrypt.Enabled = false;
            buttonDecrypt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonDecrypt.Location = new System.Drawing.Point(592, 288);
            buttonDecrypt.Name = "buttonDecrypt";
            buttonDecrypt.Size = new System.Drawing.Size(94, 29);
            buttonDecrypt.TabIndex = 7;
            buttonDecrypt.Text = "Decrypt";
            buttonDecrypt.UseVisualStyleBackColor = true;
            buttonDecrypt.Click += buttonDecrypt_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxDebug);
            groupBox3.Location = new System.Drawing.Point(13, 350);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(775, 77);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            // 
            // textBoxDebug
            // 
            textBoxDebug.Location = new System.Drawing.Point(10, 35);
            textBoxDebug.Name = "textBoxDebug";
            textBoxDebug.ReadOnly = true;
            textBoxDebug.Size = new System.Drawing.Size(747, 27);
            textBoxDebug.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button5
            // 
            button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button5.Location = new System.Drawing.Point(316, 288);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(94, 29);
            button5.TabIndex = 14;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 441);
            Controls.Add(button5);
            Controls.Add(groupBox3);
            Controls.Add(buttonDecrypt);
            Controls.Add(groupBox2);
            Controls.Add(buttonExit);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Decryption AES";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDcryptPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEncrypted;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxDebug;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textIP;
    }
}

