using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FrmLab
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            FrmRegistration.FrmRegistration registrationForm = new FrmRegistration.FrmRegistration();
            registrationForm.Show();
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string directoryPath = @"C:\Users\Dell\Documents"; // Change to your directory
            string fileName = "part2.txt"; // Change to your file name
            string filePath = Path.Combine(directoryPath, fileName);

            // Check if the file exists
            if (File.Exists(filePath))
            {
                MessageBox.Show("File found: " + filePath);
                try { 
                string[] lines = File.ReadAllLines(filePath);
                
                foreach (string line in lines)
                {
                    listView1.Items.Add(new ListViewItem(line));
                    
                }
            }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while reading the file: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("File not found.");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!");
            listView1.Items.Clear();
        }
    }
}