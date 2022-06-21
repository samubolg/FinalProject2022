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
    public partial class ProduceScreen : UserControl
    {
        public ProduceScreen()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainScreen gs = new MainScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);
        }

        public void appleButton_Click(object sender, EventArgs e)
        {
            if (voidButton.BackColor == Color.White)
            {
                double appleTotal =+ 1;
            }
            else
            {
                double appleTotal =- 1;
                voidButton.BackColor = Color.White;
            }
            receiptLabel.Text += $"\nApple @ $0.70";
        }

        private void celeryButton_Click(object sender, EventArgs e)
        {
            if (voidButton.BackColor == Color.White)
            {
                double celeryTotal = +1;
            }
            else
            {
                double celeryTotal = -1;
                voidButton.BackColor = Color.White;
            }
        }
    }
}
