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

            TaskCard_DoneChanged();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            UserControlTaskCard newTaskCard = new UserControlTaskCard();

            //connect method NewTaskCard_TaskCardRemoving to event ("pointer")
            newTaskCard.TaskCardRemoving += TaskCard_TaskCardRemoving;
            newTaskCard.DoneChanged += TaskCard_DoneChanged;

            flowLayoutPanelTaskList.Controls.Add(newTaskCard);

            TaskCard_DoneChanged();
        }

        private void TaskCard_DoneChanged()
        {
            int allTasks = 0;
            int doneTasks = 0;
            foreach (Control control in flowLayoutPanelTaskList.Controls)
            {
                if (control is UserControlTaskCard)
                {
                    UserControlTaskCard currentTaskCard = control as UserControlTaskCard;
                    if (currentTaskCard.TaskDone)
                    {
                        doneTasks++;
                    }
                    allTasks++;
                }
            }
            labelSummary.Text = $"Done: {doneTasks}/{allTasks}";
        }

        private void TaskCard_TaskCardRemoving(UserControlTaskCard sender)
        {
            //remove TaskCard
            flowLayoutPanelTaskList.Controls.Remove(sender);

            TaskCard_DoneChanged();
        }
    }
}
