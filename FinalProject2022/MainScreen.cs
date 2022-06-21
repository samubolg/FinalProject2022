using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject2022
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        public static void MainScreen_Load(object sender, EventArgs e)
        {
            double appleCost = .70;
            double appleTotal;
            double celeryCost = 2.00;
            double celeryTotal;
        }

        private void produceButton_Click(object sender, EventArgs e)
        {
            ProduceScreen gs = new ProduceScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);
        }

        private void frozenButton_Click(object sender, EventArgs e)
        {
            FrozenScreen gs = new FrozenScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);
        }

        private void groceryButton1_Click(object sender, EventArgs e)
        {
            GroceryScreen1 gs = new GroceryScreen1();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);
        }

        private void groceryButton2_Click(object sender, EventArgs e)
        {
            GroceryScreen2 gs = new GroceryScreen2();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);
        }

        private void dairyButton_Click(object sender, EventArgs e)
        {
            DairyScreen gs = new DairyScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);
        }

        private void meatButton_Click(object sender, EventArgs e)
        {
            MeatScreen gs = new MeatScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);
        }
    }
}
