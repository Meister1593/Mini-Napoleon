// 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniNapoleon.Properties;
//115 

namespace MiniNapoleon
{
    public partial class MainForm : Form
    {
        CharProcessingUnit chrProcessUnit = new CharProcessingUnit();

        public MainForm()
        {
            InitializeComponent();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string finalText = chrProcessUnit.TextToInts(EncryptTextbox.Text).ToString();
            EncryptTextbox.Text = "";
            EncryptTextbox.Text = finalText;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string finalText = "";
            finalText = chrProcessUnit.IntsToText(DecryptTextbox.Text).ToString();
            DecryptTextbox.Text = "";
            DecryptTextbox.Text = finalText;
        }

        private void OpenCodeTable_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"napo_codes.jpg");
            }
            catch (Win32Exception)
            {
                MessageBox.Show("Изображение не найдено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}