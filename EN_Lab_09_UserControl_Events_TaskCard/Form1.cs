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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            UserControlTaskCard newTaskCard = new UserControlTaskCard();

            flowLayoutPanelTaskList.Controls.Add(newTaskCard);
        }
    }
}
