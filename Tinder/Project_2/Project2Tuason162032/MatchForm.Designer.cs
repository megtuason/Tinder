namespace Project2Tuason162032
{
    partial class MatchForm
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
            this.matchName = new System.Windows.Forms.Label();
            this.matchAge = new System.Windows.Forms.Label();
            this.matchGender = new System.Windows.Forms.Label();
            this.btnLike = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userGenderPref
            // 
            this.userGenderPref.AutoSize = true;
            this.userGenderPref.Location = new System.Drawing.Point(37, 32);
            this.userGenderPref.Name = "userGenderPref";
            this.userGenderPref.Size = new System.Drawing.Size(35, 13);
            this.userGenderPref.TabIndex = 0;
            this.userGenderPref.Text = "label1";
            // 
            // userAgeRange
            // 
            this.userAgeRange.AutoSize = true;
            this.userAgeRange.Location = new System.Drawing.Point(37, 45);
            this.userAgeRange.Name = "userAgeRange";
            this.userAgeRange.Size = new System.Drawing.Size(35, 13);
            this.userAgeRange.TabIndex = 1;
            this.userAgeRange.Text = "label2";
            // 
            // matchName
            // 
            this.matchName.AutoSize = true;
            this.matchName.Location = new System.Drawing.Point(127, 71);
            this.matchName.Name = "matchName";
            this.matchName.Size = new System.Drawing.Size(35, 13);
            this.matchName.TabIndex = 2;
            this.matchName.Text = "label3";
            // 
            // matchAge
            // 
            this.matchAge.AutoSize = true;
            this.matchAge.Location = new System.Drawing.Point(127, 99);
            this.matchAge.Name = "matchAge";
            this.matchAge.Size = new System.Drawing.Size(35, 13);
            this.matchAge.TabIndex = 3;
            this.matchAge.Text = "label4";
            // 
            // matchGender
            // 
            this.matchGender.AutoSize = true;
            this.matchGender.Location = new System.Drawing.Point(127, 129);
            this.matchGender.Name = "matchGender";
            this.matchGender.Size = new System.Drawing.Size(35, 13);
            this.matchGender.TabIndex = 4;
            this.matchGender.Text = "label5";
            // 
            // btnLike
            // 
            this.btnLike.Location = new System.Drawing.Point(103, 156);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(81, 39);
            this.btnLike.TabIndex = 5;
            this.btnLike.Text = "Like";
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(103, 201);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(81, 39);
            this.btnNo.TabIndex = 6;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // MatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.matchGender);
            this.Controls.Add(this.matchAge);
            this.Controls.Add(this.matchName);
            this.Controls.Add(this.userAgeRange);
            this.Controls.Add(this.userGenderPref);
            this.Name = "MatchForm";
            this.Text = "MatchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userGenderPref;
        private System.Windows.Forms.Label userAgeRange;
        private System.Windows.Forms.Label matchName;
        private System.Windows.Forms.Label matchAge;
        private System.Windows.Forms.Label matchGender;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnNo;
    }
}