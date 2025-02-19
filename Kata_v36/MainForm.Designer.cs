﻿
namespace Scheduler
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox_Applicants = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_FreeMeetingSpots = new System.Windows.Forms.Label();
            this.button_RandomlyAssignApplicants = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_CaseWorkerSchedules = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox_Applicants);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 1023);
            this.panel1.TabIndex = 0;
            // 
            // listBox_Applicants
            // 
            this.listBox_Applicants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Applicants.FormattingEnabled = true;
            this.listBox_Applicants.ItemHeight = 32;
            this.listBox_Applicants.Location = new System.Drawing.Point(0, 107);
            this.listBox_Applicants.Name = "listBox_Applicants";
            this.listBox_Applicants.Size = new System.Drawing.Size(499, 916);
            this.listBox_Applicants.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_FreeMeetingSpots);
            this.panel2.Controls.Add(this.button_RandomlyAssignApplicants);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(499, 67);
            this.panel2.TabIndex = 3;
            // 
            // label_FreeMeetingSpots
            // 
            this.label_FreeMeetingSpots.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_FreeMeetingSpots.AutoSize = true;
            this.label_FreeMeetingSpots.Location = new System.Drawing.Point(0, 17);
            this.label_FreeMeetingSpots.Name = "label_FreeMeetingSpots";
            this.label_FreeMeetingSpots.Size = new System.Drawing.Size(244, 32);
            this.label_FreeMeetingSpots.TabIndex = 4;
            this.label_FreeMeetingSpots.Text = "Free meeting spots: 0";
            // 
            // button_RandomlyAssignApplicants
            // 
            this.button_RandomlyAssignApplicants.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_RandomlyAssignApplicants.Location = new System.Drawing.Point(275, 10);
            this.button_RandomlyAssignApplicants.Name = "button_RandomlyAssignApplicants";
            this.button_RandomlyAssignApplicants.Size = new System.Drawing.Size(214, 47);
            this.button_RandomlyAssignApplicants.TabIndex = 2;
            this.button_RandomlyAssignApplicants.Text = "Assign Applicants";
            this.button_RandomlyAssignApplicants.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Applicants";
            // 
            // flowLayoutPanel_CaseWorkerSchedules
            // 
            this.flowLayoutPanel_CaseWorkerSchedules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_CaseWorkerSchedules.Location = new System.Drawing.Point(499, 0);
            this.flowLayoutPanel_CaseWorkerSchedules.Name = "flowLayoutPanel_CaseWorkerSchedules";
            this.flowLayoutPanel_CaseWorkerSchedules.Padding = new System.Windows.Forms.Padding(50);
            this.flowLayoutPanel_CaseWorkerSchedules.Size = new System.Drawing.Size(1588, 1023);
            this.flowLayoutPanel_CaseWorkerSchedules.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2087, 1023);
            this.Controls.Add(this.flowLayoutPanel_CaseWorkerSchedules);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox_Applicants;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_RandomlyAssignApplicants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_CaseWorkerSchedules;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label_FreeMeetingSpots;
    }
}

