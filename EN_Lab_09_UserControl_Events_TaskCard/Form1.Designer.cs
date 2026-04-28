
namespace EN_Lab_09_UserControl_Events_TaskCard
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelSummary = new System.Windows.Forms.Label();
            this.flowLayoutPanelTaskList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(27, 25);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(193, 23);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Create new Task";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelSummary
            // 
            this.labelSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSummary.AutoSize = true;
            this.labelSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSummary.Location = new System.Drawing.Point(377, 25);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(83, 20);
            this.labelSummary.TabIndex = 1;
            this.labelSummary.Text = "Summary";
            this.labelSummary.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // flowLayoutPanelTaskList
            // 
            this.flowLayoutPanelTaskList.AutoSize = true;
            this.flowLayoutPanelTaskList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelTaskList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelTaskList.Location = new System.Drawing.Point(27, 55);
            this.flowLayoutPanelTaskList.MaximumSize = new System.Drawing.Size(0, 700);
            this.flowLayoutPanelTaskList.Name = "flowLayoutPanelTaskList";
            this.flowLayoutPanelTaskList.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanelTaskList.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(492, 424);
            this.Controls.Add(this.flowLayoutPanelTaskList);
            this.Controls.Add(this.labelSummary);
            this.Controls.Add(this.buttonCreate);
            this.Name = "Form1";
            this.Text = "1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTaskList;
    }
}

