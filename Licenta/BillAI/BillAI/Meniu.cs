using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillAI
{
    public partial class Meniu : Form
    {
        public Meniu()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Setari setari = new Setari();
            setari.ShowDialog();
            this.Close();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
