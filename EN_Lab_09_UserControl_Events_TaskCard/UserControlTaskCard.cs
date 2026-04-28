using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EN_Lab_09_UserControl_Events_TaskCard
{
    public partial class UserControlTaskCard : UserControl
    {
        public UserControlTaskCard()
        {
            InitializeComponent();

            textBoxTitle.Text = "New task";
            checkBoxDone.Checked = false;
            this.BackColor = Color.White;
        }

        private void buttonBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            colorDialog.Color = this.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }
    }
}
