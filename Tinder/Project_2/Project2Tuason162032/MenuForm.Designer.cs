﻿namespace Project2Tuason162032
{
    partial class MenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnViewMatches = new System.Windows.Forms.Button();
            this.btnViewPeopleList = new System.Windows.Forms.Button();
            this.btnEditUserSettings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAIN MENU";
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(90, 52);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(102, 23);
            this.btnMatch.TabIndex = 1;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // btnViewMatches
            // 
            this.btnViewMatches.Location = new System.Drawing.Point(90, 81);
            this.btnViewMatches.Name = "btnViewMatches";
            this.btnViewMatches.Size = new System.Drawing.Size(102, 23);
            this.btnViewMatches.TabIndex = 2;
            this.btnViewMatches.Text = "View Matches";
            this.btnViewMatches.UseVisualStyleBackColor = true;
            this.btnViewMatches.Click += new System.EventHandler(this.btnViewMatches_Click);
            // 
            // btnViewPeopleList
            // 
            this.btnViewPeopleList.Location = new System.Drawing.Point(90, 110);
            this.btnViewPeopleList.Name = "btnViewPeopleList";
            this.btnViewPeopleList.Size = new System.Drawing.Size(102, 23);
            this.btnViewPeopleList.TabIndex = 3;
            this.btnViewPeopleList.Text = "View People List";
            this.btnViewPeopleList.UseVisualStyleBackColor = true;
            this.btnViewPeopleList.Click += new System.EventHandler(this.btnViewPeopleList_Click);
            // 
            // btnEditUserSettings
            // 
            this.btnEditUserSettings.Location = new System.Drawing.Point(90, 139);
            this.btnEditUserSettings.Name = "btnEditUserSettings";
            this.btnEditUserSettings.Size = new System.Drawing.Size(102, 23);
            this.btnEditUserSettings.TabIndex = 4;
            this.btnEditUserSettings.Text = "Edit User Settings";
            this.btnEditUserSettings.UseVisualStyleBackColor = true;
            this.btnEditUserSettings.Click += new System.EventHandler(this.btnEditUserSettings_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(90, 168);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(102, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEditUserSettings);
            this.Controls.Add(this.btnViewPeopleList);
            this.Controls.Add(this.btnViewMatches);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.label1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnViewMatches;
        private System.Windows.Forms.Button btnViewPeopleList;
        private System.Windows.Forms.Button btnEditUserSettings;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label2;
    }
}