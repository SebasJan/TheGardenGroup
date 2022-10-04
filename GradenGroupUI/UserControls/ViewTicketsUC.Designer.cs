﻿namespace GradenGroupUI.UserControls
{
    partial class ViewTicketsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dockPanel = new System.Windows.Forms.Panel();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonResolved = new System.Windows.Forms.Button();
            this.itemSubjectTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.allTicketsListView = new System.Windows.Forms.ListView();
            this.subject = new System.Windows.Forms.ColumnHeader();
            this.description = new System.Windows.Forms.ColumnHeader();
            this.reportedAt = new System.Windows.Forms.ColumnHeader();
            this.priority = new System.Windows.Forms.ColumnHeader();
            this.deadline = new System.Windows.Forms.ColumnHeader();
            this.status = new System.Windows.Forms.ColumnHeader();
            this.welcomeText = new System.Windows.Forms.Label();
            this.createNewTicketButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.dockPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockPanel
            // 
            this.dockPanel.Controls.Add(this.buttonOpen);
            this.dockPanel.Controls.Add(this.buttonClose);
            this.dockPanel.Controls.Add(this.buttonResolved);
            this.dockPanel.Controls.Add(this.itemSubjectTextBox);
            this.dockPanel.Controls.Add(this.label2);
            this.dockPanel.Controls.Add(this.allTicketsListView);
            this.dockPanel.Location = new System.Drawing.Point(3, 75);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(1649, 550);
            this.dockPanel.TabIndex = 2;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(184, 492);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 5;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(103, 492);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonResolved
            // 
            this.buttonResolved.Location = new System.Drawing.Point(22, 492);
            this.buttonResolved.Name = "buttonResolved";
            this.buttonResolved.Size = new System.Drawing.Size(75, 23);
            this.buttonResolved.TabIndex = 3;
            this.buttonResolved.Text = "Resolve";
            this.buttonResolved.UseVisualStyleBackColor = true;
            this.buttonResolved.Click += new System.EventHandler(this.buttonResolved_Click);
            // 
            // itemSubjectTextBox
            // 
            this.itemSubjectTextBox.Location = new System.Drawing.Point(23, 456);
            this.itemSubjectTextBox.Name = "itemSubjectTextBox";
            this.itemSubjectTextBox.PlaceholderText = "Item subject.....";
            this.itemSubjectTextBox.ReadOnly = true;
            this.itemSubjectTextBox.Size = new System.Drawing.Size(236, 23);
            this.itemSubjectTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1110, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status of your tickets:";
            // 
            // allTicketsListView
            // 
            this.allTicketsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.subject,
            this.description,
            this.reportedAt,
            this.priority,
            this.deadline,
            this.status});
            this.allTicketsListView.Location = new System.Drawing.Point(23, 9);
            this.allTicketsListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allTicketsListView.Name = "allTicketsListView";
            this.allTicketsListView.Size = new System.Drawing.Size(1059, 429);
            this.allTicketsListView.TabIndex = 0;
            this.allTicketsListView.UseCompatibleStateImageBehavior = false;
            this.allTicketsListView.View = System.Windows.Forms.View.Details;
            this.allTicketsListView.SelectedIndexChanged += new System.EventHandler(this.allTicketsListView_SelectedIndexChanged);
            // 
            // subject
            // 
            this.subject.Text = "Subject:";
            this.subject.Width = 200;
            // 
            // description
            // 
            this.description.Text = "Description:";
            this.description.Width = 400;
            // 
            // reportedAt
            // 
            this.reportedAt.Text = "Date reported:";
            this.reportedAt.Width = 150;
            // 
            // priority
            // 
            this.priority.Text = "Priority:";
            this.priority.Width = 100;
            // 
            // deadline
            // 
            this.deadline.Text = "Deadline:";
            this.deadline.Width = 100;
            // 
            // status
            // 
            this.status.Text = "Status:";
            this.status.Width = 100;
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomeText.Location = new System.Drawing.Point(25, 19);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(153, 32);
            this.welcomeText.TabIndex = 4;
            this.welcomeText.Text = "Welcome {User}";
            this.welcomeText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // createNewTicketButton
            // 
            this.createNewTicketButton.BackColor = System.Drawing.Color.White;
            this.createNewTicketButton.Location = new System.Drawing.Point(1256, 19);
            this.createNewTicketButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createNewTicketButton.Name = "createNewTicketButton";
            this.createNewTicketButton.Size = new System.Drawing.Size(173, 42);
            this.createNewTicketButton.TabIndex = 5;
            this.createNewTicketButton.Text = "Create new Ticket";
            this.createNewTicketButton.UseVisualStyleBackColor = false;
            this.createNewTicketButton.Click += new System.EventHandler(this.createNewTicketButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Here you can view and create tickets.";
            // 
            // ViewTicketsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createNewTicketButton);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.dockPanel);
            this.Name = "ViewTicketsUC";
            this.Size = new System.Drawing.Size(1672, 628);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.dockPanel.ResumeLayout(false);
            this.dockPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel dockPanel;
        private System.Windows.Forms.ListView allTicketsListView;
        private System.Windows.Forms.ColumnHeader reportedAt;
        private System.Windows.Forms.ColumnHeader subject;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader priority;
        private System.Windows.Forms.ColumnHeader deadline;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.Button createNewTicketButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemSubjectTextBox;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonResolved;
        private System.Windows.Forms.Button buttonOpen;
    }
}
