﻿namespace ParkingManagement
{
    partial class RemoveMember
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
            this.CloseButton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.membersDataGridView = new System.Windows.Forms.DataGridView();
            this.removeUserIDButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton1
            // 
            this.CloseButton1.BackColor = System.Drawing.Color.Firebrick;
            this.CloseButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton1.Location = new System.Drawing.Point(83, 44);
            this.CloseButton1.Name = "CloseButton1";
            this.CloseButton1.Size = new System.Drawing.Size(75, 23);
            this.CloseButton1.TabIndex = 3;
            this.CloseButton1.Text = "X";
            this.CloseButton1.UseVisualStyleBackColor = false;
            this.CloseButton1.Click += new System.EventHandler(this.CloseButton1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(297, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 60);
            this.label2.TabIndex = 6;
            this.label2.Text = "Remove Member";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(2, 2);
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.membersDataGridView);
            this.panel1.Controls.Add(this.removeUserIDButton);
            this.panel1.Location = new System.Drawing.Point(83, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 355);
            this.panel1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.iDTextBox);
            this.panel2.Location = new System.Drawing.Point(119, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 65);
            this.panel2.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Aqua;
            this.label8.Location = new System.Drawing.Point(48, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 25);
            this.label8.TabIndex = 56;
            this.label8.Text = "ID: ";
            // 
            // iDTextBox
            // 
            this.iDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDTextBox.Location = new System.Drawing.Point(108, 17);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(332, 30);
            this.iDTextBox.TabIndex = 58;
            // 
            // membersDataGridView
            // 
            this.membersDataGridView.AllowUserToAddRows = false;
            this.membersDataGridView.AllowUserToDeleteRows = false;
            this.membersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.membersDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.membersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.membersDataGridView.Name = "membersDataGridView";
            this.membersDataGridView.ReadOnly = true;
            this.membersDataGridView.RowHeadersWidth = 51;
            this.membersDataGridView.RowTemplate.Height = 24;
            this.membersDataGridView.Size = new System.Drawing.Size(746, 191);
            this.membersDataGridView.TabIndex = 57;
            // 
            // removeUserIDButton
            // 
            this.removeUserIDButton.BackColor = System.Drawing.Color.BlueViolet;
            this.removeUserIDButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.removeUserIDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeUserIDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeUserIDButton.ForeColor = System.Drawing.Color.Black;
            this.removeUserIDButton.Location = new System.Drawing.Point(313, 288);
            this.removeUserIDButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeUserIDButton.Name = "removeUserIDButton";
            this.removeUserIDButton.Size = new System.Drawing.Size(151, 48);
            this.removeUserIDButton.TabIndex = 15;
            this.removeUserIDButton.Text = "Remove";
            this.removeUserIDButton.UseVisualStyleBackColor = false;
            this.removeUserIDButton.Click += new System.EventHandler(this.removeUserIDButton_Click);
            // 
            // RemoveMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(871, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseButton1);
            this.Name = "RemoveMember";
            this.Text = "Remove Member";
            this.Load += new System.EventHandler(this.RemoveMember_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox iDTextBox;
        public System.Windows.Forms.DataGridView membersDataGridView;
        private System.Windows.Forms.Button removeUserIDButton;
    }
}