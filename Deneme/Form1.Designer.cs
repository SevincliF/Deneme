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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartSimulation
            // 
            this.btnStartSimulation.Location = new System.Drawing.Point(218, 46);
            this.btnStartSimulation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStartSimulation.Name = "btnStartSimulation";
            this.btnStartSimulation.Size = new System.Drawing.Size(151, 19);
            this.btnStartSimulation.TabIndex = 0;
            this.btnStartSimulation.Text = "Start";
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
            this.comboBoxIsolationLevel.Location = new System.Drawing.Point(218, 10);
            this.comboBoxIsolationLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxIsolationLevel.Name = "comboBoxIsolationLevel";
            this.comboBoxIsolationLevel.Size = new System.Drawing.Size(151, 21);
            this.comboBoxIsolationLevel.TabIndex = 5;
            // 
            // lblTypeAUsers
            // 
            this.lblTypeAUsers.AutoSize = true;
            this.lblTypeAUsers.Location = new System.Drawing.Point(37, 14);
            this.lblTypeAUsers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeAUsers.Name = "lblTypeAUsers";
            this.lblTypeAUsers.Size = new System.Drawing.Size(71, 13);
            this.lblTypeAUsers.TabIndex = 2;
            this.lblTypeAUsers.Text = "Type A Users";
            // 
            // lblTypeBUsers
            // 
            this.lblTypeBUsers.AutoSize = true;
            this.lblTypeBUsers.Location = new System.Drawing.Point(37, 52);
            this.lblTypeBUsers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeBUsers.Name = "lblTypeBUsers";
            this.lblTypeBUsers.Size = new System.Drawing.Size(71, 13);
            this.lblTypeBUsers.TabIndex = 3;
            this.lblTypeBUsers.Text = "Type B Users";
            // 
            // txtTypeAUsers
            // 
            this.txtTypeAUsers.Location = new System.Drawing.Point(112, 11);
            this.txtTypeAUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTypeAUsers.Name = "txtTypeAUsers";
            this.txtTypeAUsers.Size = new System.Drawing.Size(76, 20);
            this.txtTypeAUsers.TabIndex = 4;
            // 
            // txtTypeBUsers
            // 
            this.txtTypeBUsers.Location = new System.Drawing.Point(112, 45);
            this.txtTypeBUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTypeBUsers.Name = "txtTypeBUsers";
            this.txtTypeBUsers.Size = new System.Drawing.Size(76, 20);
            this.txtTypeBUsers.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 82);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1340, 685);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 778);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxIsolationLevel);
            this.Controls.Add(this.txtTypeBUsers);
            this.Controls.Add(this.txtTypeAUsers);
            this.Controls.Add(this.lblTypeBUsers);
            this.Controls.Add(this.lblTypeAUsers);
            this.Controls.Add(this.btnStartSimulation);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnStartSimulation;
        private System.Windows.Forms.ComboBox comboBoxIsolationLevel;
        private System.Windows.Forms.Label lblTypeAUsers;
        private System.Windows.Forms.Label lblTypeBUsers;
        private System.Windows.Forms.TextBox txtTypeAUsers;
        private System.Windows.Forms.TextBox txtTypeBUsers;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
