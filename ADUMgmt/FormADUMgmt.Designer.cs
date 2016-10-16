namespace ADUMgmt {
    partial class FormADUMgmt {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpUsers = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tvUsers = new System.Windows.Forms.TreeView();
            this.gbDepartments = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tpUsers.SuspendLayout();
            this.gbDepartments.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpUsers);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 538);
            this.tabControl1.TabIndex = 0;
            // 
            // tpUsers
            // 
            this.tpUsers.Controls.Add(this.gbDepartments);
            this.tpUsers.Location = new System.Drawing.Point(4, 22);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsers.Size = new System.Drawing.Size(776, 512);
            this.tpUsers.TabIndex = 0;
            this.tpUsers.Text = "Users";
            this.tpUsers.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // msMain
            // 
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(784, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "Main Menu";
            // 
            // tvUsers
            // 
            this.tvUsers.Location = new System.Drawing.Point(85, 110);
            this.tvUsers.Name = "tvUsers";
            this.tvUsers.Size = new System.Drawing.Size(418, 343);
            this.tvUsers.TabIndex = 0;
            // 
            // gbDepartments
            // 
            this.gbDepartments.Controls.Add(this.tvUsers);
            this.gbDepartments.Location = new System.Drawing.Point(6, 6);
            this.gbDepartments.Name = "gbDepartments";
            this.gbDepartments.Size = new System.Drawing.Size(414, 386);
            this.gbDepartments.TabIndex = 1;
            this.gbDepartments.TabStop = false;
            this.gbDepartments.Text = "Departments";
            // 
            // FormADUMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormADUMgmt";
            this.Text = "ADUM";
            this.tabControl1.ResumeLayout(false);
            this.tpUsers.ResumeLayout(false);
            this.gbDepartments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpUsers;
        private System.Windows.Forms.GroupBox gbDepartments;
        private System.Windows.Forms.TreeView tvUsers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip msMain;
    }
}

