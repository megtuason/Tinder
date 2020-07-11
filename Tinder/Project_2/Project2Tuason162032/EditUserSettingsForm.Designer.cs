namespace Project2Tuason162032
{
    partial class EditUserSettingsForm
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
            this.userGenderPref = new System.Windows.Forms.Label();
            this.userAgeRange = new System.Windows.Forms.Label();
            this.btnEditPref = new System.Windows.Forms.Button();
            this.btnEditAgeRange = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userGenderPref
            // 
            this.userGenderPref.AutoSize = true;
            this.userGenderPref.Location = new System.Drawing.Point(92, 74);
            this.userGenderPref.Name = "userGenderPref";
            this.userGenderPref.Size = new System.Drawing.Size(35, 13);
            this.userGenderPref.TabIndex = 0;
            this.userGenderPref.Text = "label1";
            // 
            // userAgeRange
            // 
            this.userAgeRange.AutoSize = true;
            this.userAgeRange.Location = new System.Drawing.Point(92, 98);
            this.userAgeRange.Name = "userAgeRange";
            this.userAgeRange.Size = new System.Drawing.Size(35, 13);
            this.userAgeRange.TabIndex = 1;
            this.userAgeRange.Text = "label2";
            // 
            // btnEditPref
            // 
            this.btnEditPref.Location = new System.Drawing.Point(83, 128);
            this.btnEditPref.Name = "btnEditPref";
            this.btnEditPref.Size = new System.Drawing.Size(115, 40);
            this.btnEditPref.TabIndex = 2;
            this.btnEditPref.Text = "EDIT SHOW ME";
            this.btnEditPref.UseVisualStyleBackColor = true;
            this.btnEditPref.Click += new System.EventHandler(this.btnEditPref_Click);
            // 
            // btnEditAgeRange
            // 
            this.btnEditAgeRange.Location = new System.Drawing.Point(83, 184);
            this.btnEditAgeRange.Name = "btnEditAgeRange";
            this.btnEditAgeRange.Size = new System.Drawing.Size(115, 40);
            this.btnEditAgeRange.TabIndex = 3;
            this.btnEditAgeRange.Text = "EDIT AGE RANGE";
            this.btnEditAgeRange.UseVisualStyleBackColor = true;
            this.btnEditAgeRange.Click += new System.EventHandler(this.btnEditAgeRange_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back to Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditUserSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditAgeRange);
            this.Controls.Add(this.btnEditPref);
            this.Controls.Add(this.userAgeRange);
            this.Controls.Add(this.userGenderPref);
            this.Name = "EditUserSettingsForm";
            this.Text = "EditUserSettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userGenderPref;
        private System.Windows.Forms.Label userAgeRange;
        private System.Windows.Forms.Button btnEditPref;
        private System.Windows.Forms.Button btnEditAgeRange;
        private System.Windows.Forms.Button button1;
    }
}