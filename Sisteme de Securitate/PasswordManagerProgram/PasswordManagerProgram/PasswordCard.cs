using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagerProgram
{
    public partial class PasswordCard : UserControl
    {
        private string name;
        private DateTime created;
        private string password;

        public PasswordCard(string _name, DateTime _created, string _password)
        {
            name = _name;
            created = _created;
            password = _password;
            InitializeComponent();
        }

        private void PasswordCard_Load(object sender, EventArgs e)
        {
            labelName.Text = name;
            labelLogo.Text = name[0].ToString();

            labelDate.Text = created.ToShortDateString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(password);
        }
    }
}
