using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagerProgram
{
    /*
     * ToDo:
     * - sa pui dialog pt MasterPassword
     * - sa iei datele din AddPassword
     * - db
     * 
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                PasswordCard passwordCard = new PasswordCard("facebook", DateTime.Now, "abc");
                passwordCard.Parent = flowLayoutPanel1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPassword addPassword = new AddPassword();
            addPassword.ShowDialog();
            
        }
    }
}
