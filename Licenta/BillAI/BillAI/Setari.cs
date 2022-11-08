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
    public partial class Setari : Form
    {
        public Setari()
        {
            InitializeComponent();
        }
        private void Setari_Load(object sender, EventArgs e)
        {
            trackBarBallSize.Value = (int)Prefs.ballSize;
            trackBarTimeScale.Value = Prefs.timeScale;

            trackBarGenerationsCount.Value = Prefs.countInGeneration;
            trackBarMutationChance.Value = Prefs.mutationChance;

            trackBarMinShootCount.Value = Prefs.minShootsCount;
            trackBarMaxShootCount.Value = Prefs.maxShootsCount;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if(trackBarMinShootCount.Value> trackBarMaxShootCount.Value)
            {
                MessageBox.Show("Numărul de lovituri minime trebuie să fie mai puțin sau egal, cu numărul maxim de lovituri!", "A apărut o problemă!!");
                return;
            }
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void trackBarBallSize_Scroll(object sender, EventArgs e)
        {
            Prefs.ballSize = trackBarBallSize.Value;
        }

        private void trackBarTimeScale_Scroll(object sender, EventArgs e)
        {
            Prefs.timeScale = trackBarTimeScale.Value;
        }

        private void trackBarGenerationsCount_Scroll(object sender, EventArgs e)
        {
            Prefs.countInGeneration = trackBarGenerationsCount.Value;
        }

        private void trackBarMutationChance_Scroll(object sender, EventArgs e)
        {
            Prefs.mutationChance = trackBarMutationChance.Value;
        }

        private void trackBarMinShootCount_Scroll(object sender, EventArgs e)
        {
            Prefs.minShootsCount = trackBarMinShootCount.Value;
        }

        private void trackBarMaxShootCount_Scroll(object sender, EventArgs e)
        {
            Prefs.maxShootsCount = trackBarMaxShootCount.Value;
        }
    }
}
