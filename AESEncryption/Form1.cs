using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Net.Http;
using AESEncryption.Model;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;
using System.Reflection.Metadata;

namespace AESEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            textBoxDcryptPassword.Text = ReceiveSocketKey(textIP.Text);

            WriteBytesToFile("_encrypted.txt", ReceiveSocketData(textIP.Text));
        }


        static byte[] ReceiveSocketData(string ip)
        {
            try
            {
                TcpClient client = new TcpClient();

                // 1. connect
                client.Connect(ip, 9999);
                NetworkStream stream = client.GetStream();

                // Create a buffer to store the received data
                byte[] buffer = new byte[1024]; // Adjust buffer size as needed

                Console.WriteLine("Connected to Y2Server.");

                // Read data from the stream
                using (MemoryStream ms = new MemoryStream())
                {
                    int bytesRead;
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        ms.Write(buffer, 0, bytesRead);
                    }

                    // Convert the accumulated bytes to a byte array
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return null;
            }
        }
        static string ReceiveSocketKey(string ip)
        {
            try
            {
                TcpClient client = new TcpClient();

                // 1. connect
                client.Connect(ip, 8888);
                Stream stream = client.GetStream();
                string result = "";
                Console.WriteLine("Connected to Y2Server.");
                while (true)
                {

                    var reader = new StreamReader(stream);
                    string response;

                    while ((response = reader.ReadLine()) != null)
                    {
                        result += response;
                    }

                    break;
                }

                // 4. close
                stream.Close();
                client.Close();
                return result;
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return "";
            }
        }


        static void WriteBytesToFile(string filePath, byte[] data)
        {
            try
            {
                // Mở hoặc tạo file mới
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    fs.SetLength(0);
                    // Ghi tất cả byte vào file
                    fs.Write(data, 0, data.Length);
                    fs.Flush(); // Đảm bảo dữ liệu được ghi ngay lập tức
                }

                // Kiểm tra xem file đã được tạo hay chưa
                if (File.Exists(filePath))
                {
                    Console.WriteLine("File created successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to create file.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
            }
        }


        static void DecryptReceivedFile(string filePath, string key)
        {
            AES.Decrypt(filePath, key);
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                //DecryptReceivedFile(textBoxEncrypted.Text, textBoxDcryptPassword.Text);
                if(textBoxDcryptPassword.Text.Length == 16)
                {
                    AES.DecryptFile(textBoxEncrypted.Text, textBoxDcryptPassword.Text, 10);
                }else if (textBoxDcryptPassword.Text.Length == 24)
                {
                    AES.DecryptFile(textBoxEncrypted.Text, textBoxDcryptPassword.Text, 12);
                }
                else if (textBoxDcryptPassword.Text.Length == 32)
                {
                    AES.DecryptFile(textBoxEncrypted.Text, textBoxDcryptPassword.Text, 14);
                }
                else
                {
                    MessageBox.Show("Password's invalid!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            //textBoxEncryptPassword.Enabled = textBoxInput.Text.Length > 0;
            //buttonEncrypt.Enabled = textBoxInput.Text.Length > 0;
        }

        private void textBoxEncryptPassword_TextChanged(object sender, EventArgs e)
        {
            //textBoxInput.Enabled = textBoxInput.Text.Length > 0;
            //buttonEncrypt.Enabled = textBoxInput.Text.Length > 0;

        }

        private void textBoxEncrypted_TextChanged(object sender, EventArgs e)
        {
            textBoxDcryptPassword.Enabled = textBoxEncrypted.Text.Length > 0;
            buttonDecrypt.Enabled = textBoxEncrypted.Text.Length > 0;
        }

        private void textBoxDcryptPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxEncrypted.Enabled = textBoxEncrypted.Text.Length > 0;
            buttonDecrypt.Enabled = textBoxEncrypted.Text.Length > 0;
            label3.Text = $"Provide password to use for descryption ({textBoxDcryptPassword.Text.Length} chars)";
        }



        private void textBoxEncryptPassword_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length != 16)
            {
                // MessageBox.Show("You need to write at least 16 characters.");
            }
        }

        private void textBoxInput_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (textBoxInput.Text.Length > 0)
            //{
            //    byte[] InputBytes = Encoding.UTF8.GetBytes(textBoxInput.Text);
            //    textBoxDebug.Text = BitConverter.ToString(InputBytes).ToLower().Replace("-", " ");
            //}
        }

        private void textBoxEncryptPassword_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (textBoxEncryptPassword.Text.Length > 0)
            //{
            //    byte[] InputBytes = Encoding.UTF8.GetBytes(textBoxEncryptPassword.Text);
            //    textBoxDebug.Text = BitConverter.ToString(InputBytes).ToLower().Replace("-", " ");
            //}
        }

        private void textBoxEncryptedOutput_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (textBoxEncryptedOutput.Text.Length > 0)
            //{
            //    byte[] InputBytes = Convert.FromBase64String(textBoxEncryptedOutput.Text);
            //    textBoxDebug.Text = BitConverter.ToString(InputBytes).ToLower().Replace("-", " ");
            //}
        }

        private void textBoxEncrypted_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            byte[] InputBytes = Convert.FromBase64String(textBoxEncrypted.Text);
            textBoxDebug.Text = BitConverter.ToString(InputBytes).ToLower().Replace("-", " ");
        }

        private void textBoxDcryptPassword_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (textBoxDcryptPassword.Text.Length > 0)
            {
                byte[] InputBytes = Encoding.UTF8.GetBytes(textBoxDcryptPassword.Text);
                textBoxDebug.Text = BitConverter.ToString(InputBytes).ToLower().Replace("-", "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(openFile.FileName))
                    {
                        string content = sr.ReadToEnd();
                        //textBoxInput.Text = content;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string randomString = "";

            int length = 16;

            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            for (int i = 0; i < length; i++)
            {
                randomString += chars[random.Next(chars.Length)];
            }
            //textBoxEncryptPassword.Text = randomString;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBoxEncrypted.Text = openFile.FileName;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            };
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            //textBoxDecryptOutput.Text = "";
            textBoxEncrypted.Text = "";
            textIP.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(openFile.FileName))
                    {
                        string content = sr.ReadToEnd();
                        textBoxDcryptPassword.Text = content;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxEncryptedOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textIP_TextChanged(object sender, EventArgs e)
        {
            
            buttonExit.Enabled = textIP.Text.Length > 0;
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
