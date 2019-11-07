namespace oah_v1
{
    partial class alogin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayResidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayVolunteerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenditureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.addRecordToolStripMenuItem,
            this.modifyRecordToolStripMenuItem,
            this.deleteRecordToolStripMenuItem,
            this.displayResidentToolStripMenuItem,
            this.displayVolunteerToolStripMenuItem,
            this.expenditureToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1057, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // addRecordToolStripMenuItem
            // 
            this.addRecordToolStripMenuItem.Name = "addRecordToolStripMenuItem";
            this.addRecordToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.addRecordToolStripMenuItem.Text = "Add Record";
            this.addRecordToolStripMenuItem.Click += new System.EventHandler(this.addRecordToolStripMenuItem_Click);
            // 
            // modifyRecordToolStripMenuItem
            // 
            this.modifyRecordToolStripMenuItem.Name = "modifyRecordToolStripMenuItem";
            this.modifyRecordToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.modifyRecordToolStripMenuItem.Text = "Modify Record";
            this.modifyRecordToolStripMenuItem.Click += new System.EventHandler(this.modifyRecordToolStripMenuItem_Click);
            // 
            // deleteRecordToolStripMenuItem
            // 
            this.deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
            this.deleteRecordToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.deleteRecordToolStripMenuItem.Text = "Delete Record";
            this.deleteRecordToolStripMenuItem.Click += new System.EventHandler(this.deleteRecordToolStripMenuItem_Click);
            // 
            // displayResidentToolStripMenuItem
            // 
            this.displayResidentToolStripMenuItem.Name = "displayResidentToolStripMenuItem";
            this.displayResidentToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.displayResidentToolStripMenuItem.Text = "Display Resident";
            this.displayResidentToolStripMenuItem.Click += new System.EventHandler(this.displayResidentToolStripMenuItem_Click);
            // 
            // displayVolunteerToolStripMenuItem
            // 
            this.displayVolunteerToolStripMenuItem.Name = "displayVolunteerToolStripMenuItem";
            this.displayVolunteerToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.displayVolunteerToolStripMenuItem.Text = "Display Volunteer";
            this.displayVolunteerToolStripMenuItem.Click += new System.EventHandler(this.displayVolunteerToolStripMenuItem_Click);
            // 
            // expenditureToolStripMenuItem
            // 
            this.expenditureToolStripMenuItem.Name = "expenditureToolStripMenuItem";
            this.expenditureToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.expenditureToolStripMenuItem.Text = "Expenditure";
            this.expenditureToolStripMenuItem.Click += new System.EventHandler(this.expenditureToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // alogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 262);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "alogin";
            this.Text = "alogin";
            this.Load += new System.EventHandler(this.alogin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayResidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayVolunteerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenditureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}