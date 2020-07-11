namespace Project2Tuason162032
{
    partial class ViewMatchesForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMatches = new System.Windows.Forms.Label();
            this.feedback = new System.Windows.Forms.Label();
            this.btnUnmatch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(43, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(463, 118);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID #";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Gender";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Age";
            this.Column4.Name = "Column4";
            // 
            // totalMatches
            // 
            this.totalMatches.AutoSize = true;
            this.totalMatches.Location = new System.Drawing.Point(40, 156);
            this.totalMatches.Name = "totalMatches";
            this.totalMatches.Size = new System.Drawing.Size(35, 13);
            this.totalMatches.TabIndex = 1;
            this.totalMatches.Text = "label1";
            // 
            // feedback
            // 
            this.feedback.AutoSize = true;
            this.feedback.Location = new System.Drawing.Point(43, 188);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(0, 13);
            this.feedback.TabIndex = 2;
            // 
            // btnUnmatch
            // 
            this.btnUnmatch.Location = new System.Drawing.Point(522, 63);
            this.btnUnmatch.Name = "btnUnmatch";
            this.btnUnmatch.Size = new System.Drawing.Size(115, 36);
            this.btnUnmatch.TabIndex = 3;
            this.btnUnmatch.Text = "UNMATCH";
            this.btnUnmatch.UseVisualStyleBackColor = true;
            this.btnUnmatch.Click += new System.EventHandler(this.btnUnmatch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back to Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewMatchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 229);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUnmatch);
            this.Controls.Add(this.feedback);
            this.Controls.Add(this.totalMatches);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewMatchesForm";
            this.Text = "ViewMatchesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label totalMatches;
        private System.Windows.Forms.Label feedback;
        private System.Windows.Forms.Button btnUnmatch;
        private System.Windows.Forms.Button button1;
    }
}