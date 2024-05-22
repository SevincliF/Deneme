namespace Deneme
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnStartSimulation = new System.Windows.Forms.Button();
            this.comboBoxIsolationLevel = new System.Windows.Forms.ComboBox();
            this.lblTypeAUsers = new System.Windows.Forms.Label();
            this.lblTypeBUsers = new System.Windows.Forms.Label();
            this.txtTypeAUsers = new System.Windows.Forms.TextBox();
            this.txtTypeBUsers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStartSimulation
            // 
            this.btnStartSimulation.Location = new System.Drawing.Point(50, 250);
            this.btnStartSimulation.Name = "btnStartSimulation";
            this.btnStartSimulation.Size = new System.Drawing.Size(100, 23);
            this.btnStartSimulation.TabIndex = 0;
            this.btnStartSimulation.Text = "Start Simulation";
            this.btnStartSimulation.UseVisualStyleBackColor = true;
            this.btnStartSimulation.Click += new System.EventHandler(this.btnStartSimulation_Click);
            // 
            // comboBoxIsolationLevel
            // 
            this.comboBoxIsolationLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIsolationLevel.FormattingEnabled = true;
            this.comboBoxIsolationLevel.Items.AddRange(new object[] {
            "Read Uncommitted",
            "Read Committed",
            "Repeatable Read",
            "Serializable"});
            this.comboBoxIsolationLevel.Location = new System.Drawing.Point(50, 200);
            this.comboBoxIsolationLevel.Name = "comboBoxIsolationLevel";
            this.comboBoxIsolationLevel.Size = new System.Drawing.Size(200, 24);
            this.comboBoxIsolationLevel.TabIndex = 5;
            // 
            // lblTypeAUsers
            // 
            this.lblTypeAUsers.AutoSize = true;
            this.lblTypeAUsers.Location = new System.Drawing.Point(50, 50);
            this.lblTypeAUsers.Name = "lblTypeAUsers";
            this.lblTypeAUsers.Size = new System.Drawing.Size(90, 16);
            this.lblTypeAUsers.TabIndex = 2;
            this.lblTypeAUsers.Text = "Type A Users";
            // 
            // lblTypeBUsers
            // 
            this.lblTypeBUsers.AutoSize = true;
            this.lblTypeBUsers.Location = new System.Drawing.Point(50, 100);
            this.lblTypeBUsers.Name = "lblTypeBUsers";
            this.lblTypeBUsers.Size = new System.Drawing.Size(90, 16);
            this.lblTypeBUsers.TabIndex = 3;
            this.lblTypeBUsers.Text = "Type B Users";
            // 
            // txtTypeAUsers
            // 
            this.txtTypeAUsers.Location = new System.Drawing.Point(150, 50);
            this.txtTypeAUsers.Name = "txtTypeAUsers";
            this.txtTypeAUsers.Size = new System.Drawing.Size(100, 22);
            this.txtTypeAUsers.TabIndex = 4;
            // 
            // txtTypeBUsers
            // 
            this.txtTypeBUsers.Location = new System.Drawing.Point(150, 100);
            this.txtTypeBUsers.Name = "txtTypeBUsers";
            this.txtTypeBUsers.Size = new System.Drawing.Size(100, 22);
            this.txtTypeBUsers.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxIsolationLevel);
            this.Controls.Add(this.txtTypeBUsers);
            this.Controls.Add(this.txtTypeAUsers);
            this.Controls.Add(this.lblTypeBUsers);
            this.Controls.Add(this.lblTypeAUsers);
            this.Controls.Add(this.btnStartSimulation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnStartSimulation;
        private System.Windows.Forms.ComboBox comboBoxIsolationLevel;
        private System.Windows.Forms.Label lblTypeAUsers;
        private System.Windows.Forms.Label lblTypeBUsers;
        private System.Windows.Forms.TextBox txtTypeAUsers;
        private System.Windows.Forms.TextBox txtTypeBUsers;
    }
}
