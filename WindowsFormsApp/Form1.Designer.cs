namespace WindowsFormsApp
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
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.lbxWeek = new System.Windows.Forms.ListBox();
            this.btnNewForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(102, 54);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(41, 15);
            this.labName.TabIndex = 0;
            this.labName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(172, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(105, 117);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(167, 36);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Click";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lbxWeek
            // 
            this.lbxWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxWeek.FormattingEnabled = true;
            this.lbxWeek.ItemHeight = 16;
            this.lbxWeek.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.lbxWeek.Location = new System.Drawing.Point(105, 207);
            this.lbxWeek.Name = "lbxWeek";
            this.lbxWeek.Size = new System.Drawing.Size(167, 132);
            this.lbxWeek.TabIndex = 4;
            this.lbxWeek.SelectedIndexChanged += new System.EventHandler(this.lbxWeek_SelectedIndexChanged);
            // 
            // btnNewForm
            // 
            this.btnNewForm.Location = new System.Drawing.Point(296, 415);
            this.btnNewForm.Name = "btnNewForm";
            this.btnNewForm.Size = new System.Drawing.Size(75, 23);
            this.btnNewForm.TabIndex = 5;
            this.btnNewForm.Text = "New Form";
            this.btnNewForm.UseVisualStyleBackColor = true;
            this.btnNewForm.Click += new System.EventHandler(this.btnNewForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.btnNewForm);
            this.Controls.Add(this.lbxWeek);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ListBox lbxWeek;
        private System.Windows.Forms.Button btnNewForm;
    }
}

