using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AesOperation_Form
{
    public partial class AesOperation_Form : Form
    {
        public AesOperation_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plaintext = textBox1.Text.ToString();
            if (string.IsNullOrEmpty(plaintext))
            {
                MessageBox.Show("plaintext required");
            }
            else
            {
               textBox3.Text = AesOperation.EncryptString(plaintext);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string encryptedText = textBox2.Text.ToString();
            if (string.IsNullOrEmpty(encryptedText))
            {
                MessageBox.Show("encryptedtext required");
            }
            else
            {
                textBox3.Text = AesOperation.DecryptString(encryptedText);
            }
        }
    }
}
