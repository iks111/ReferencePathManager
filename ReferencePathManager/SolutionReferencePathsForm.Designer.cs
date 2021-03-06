﻿namespace ReferencePathManager
{
	partial class SolutionReferencePathsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolutionReferencePathsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ProjectsLv = new System.Windows.Forms.ListView();
            this.PathsLv = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.AddFromClipboardButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteAllButton = new System.Windows.Forms.ToolStripButton();
            this.PropagateButton = new System.Windows.Forms.ToolStripButton();
            this.PropagateAllButton = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AcceptBtn);
            this.panel1.Controls.Add(this.CancelBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 646);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 49);
            this.panel1.TabIndex = 0;
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptBtn.Location = new System.Drawing.Point(882, 9);
            this.AcceptBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(112, 35);
            this.AcceptBtn.TabIndex = 1;
            this.AcceptBtn.Text = "&Accept";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(1004, 9);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(112, 35);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "&Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // ProjectsLv
            // 
            this.ProjectsLv.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProjectsLv.Location = new System.Drawing.Point(0, 0);
            this.ProjectsLv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProjectsLv.Name = "ProjectsLv";
            this.ProjectsLv.Size = new System.Drawing.Size(342, 646);
            this.ProjectsLv.TabIndex = 3;
            this.ProjectsLv.UseCompatibleStateImageBehavior = false;
            this.ProjectsLv.View = System.Windows.Forms.View.List;
            this.ProjectsLv.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ProjectsLv_ItemSelectionChanged);
            // 
            // PathsLv
            // 
            this.PathsLv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathsLv.Location = new System.Drawing.Point(0, 0);
            this.PathsLv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PathsLv.Name = "PathsLv";
            this.PathsLv.Size = new System.Drawing.Size(788, 614);
            this.PathsLv.TabIndex = 5;
            this.PathsLv.UseCompatibleStateImageBehavior = false;
            this.PathsLv.View = System.Windows.Forms.View.List;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.splitter1);
            this.panel3.Controls.Add(this.ProjectsLv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1134, 646);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.toolStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(346, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(788, 646);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.PathsLv);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 32);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(788, 614);
            this.panel5.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddButton,
            this.AddFromClipboardButton,
            this.DeleteButton,
            this.DeleteAllButton,
            this.PropagateButton,
            this.PropagateAllButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(788, 32);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddButton
            // 
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(50, 29);
            this.AddButton.Text = "Add";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddFromClipboardButton
            // 
            this.AddFromClipboardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddFromClipboardButton.Image = ((System.Drawing.Image)(resources.GetObject("AddFromClipboardButton.Image")));
            this.AddFromClipboardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddFromClipboardButton.Name = "AddFromClipboardButton";
            this.AddFromClipboardButton.Size = new System.Drawing.Size(180, 29);
            this.AddFromClipboardButton.Text = "Add From Clipboard";
            this.AddFromClipboardButton.Click += new System.EventHandler(this.HandleAddFromClipboard);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(66, 29);
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteAllButton
            // 
            this.DeleteAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeleteAllButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteAllButton.Image")));
            this.DeleteAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteAllButton.Name = "DeleteAllButton";
            this.DeleteAllButton.Size = new System.Drawing.Size(91, 29);
            this.DeleteAllButton.Text = "Delete All";
            this.DeleteAllButton.Click += new System.EventHandler(this.DeleteAllButton_Click);
            // 
            // PropagateButton
            // 
            this.PropagateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PropagateButton.Image = ((System.Drawing.Image)(resources.GetObject("PropagateButton.Image")));
            this.PropagateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PropagateButton.Name = "PropagateButton";
            this.PropagateButton.Size = new System.Drawing.Size(98, 29);
            this.PropagateButton.Text = "Propagate";
            this.PropagateButton.Click += new System.EventHandler(this.PropagateButton_Click);
            // 
            // PropagateAllButton
            // 
            this.PropagateAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PropagateAllButton.Image = ((System.Drawing.Image)(resources.GetObject("PropagateAllButton.Image")));
            this.PropagateAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PropagateAllButton.Name = "PropagateAllButton";
            this.PropagateAllButton.Size = new System.Drawing.Size(123, 29);
            this.PropagateAllButton.Text = "Propagate All";
            this.PropagateAllButton.Click += new System.EventHandler(this.PropagateAllButton_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(342, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 646);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // SolutionReferencePathsForm
            // 
            this.AcceptButton = this.AcceptBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(1134, 695);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SolutionReferencePathsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solution Reference Paths";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button AcceptBtn;
		private System.Windows.Forms.Button CancelBtn;
		private System.Windows.Forms.ListView ProjectsLv;
		private System.Windows.Forms.ListView PathsLv;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.ToolStripButton DeleteButton;
		private System.Windows.Forms.ToolStripButton DeleteAllButton;
		private System.Windows.Forms.ToolStripButton AddButton;
		private System.Windows.Forms.ToolStripButton PropagateButton;
		private System.Windows.Forms.ToolStripButton PropagateAllButton;
		private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.ToolStripButton AddFromClipboardButton;
    }
}