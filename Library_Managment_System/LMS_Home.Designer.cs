namespace Library_Managment_System_Integrated
{
    partial class LMS_Home
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.maintenaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enquiryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookEnquiryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(145, 50);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(298, 25);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Library Managment System";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintenaceToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.enquiryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(67, 148);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 50);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // maintenaceToolStripMenuItem
            // 
            this.maintenaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintainBooksToolStripMenuItem});
            this.maintenaceToolStripMenuItem.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenaceToolStripMenuItem.Name = "maintenaceToolStripMenuItem";
            this.maintenaceToolStripMenuItem.Size = new System.Drawing.Size(124, 46);
            this.maintenaceToolStripMenuItem.Text = "Maintenace";
            // 
            // maintainBooksToolStripMenuItem
            // 
            this.maintainBooksToolStripMenuItem.Name = "maintainBooksToolStripMenuItem";
            this.maintainBooksToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.maintainBooksToolStripMenuItem.Text = "Maintain Books";
            this.maintainBooksToolStripMenuItem.Click += new System.EventHandler(this.maintainBooksToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issueBooksToolStripMenuItem,
            this.returnBookToolStripMenuItem});
            this.transactionToolStripMenuItem.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(127, 46);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // issueBooksToolStripMenuItem
            // 
            this.issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            this.issueBooksToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.issueBooksToolStripMenuItem.Text = "Issue Book";
            this.issueBooksToolStripMenuItem.Click += new System.EventHandler(this.issueBooksToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.returnBookToolStripMenuItem.Text = "Return Book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberRegistrationToolStripMenuItem});
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(77, 46);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // memberRegistrationToolStripMenuItem
            // 
            this.memberRegistrationToolStripMenuItem.Name = "memberRegistrationToolStripMenuItem";
            this.memberRegistrationToolStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.memberRegistrationToolStripMenuItem.Text = "Member Registration";
            this.memberRegistrationToolStripMenuItem.Click += new System.EventHandler(this.memberRegistrationToolStripMenuItem_Click);
            // 
            // enquiryToolStripMenuItem
            // 
            this.enquiryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookEnquiryToolStripMenuItem});
            this.enquiryToolStripMenuItem.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enquiryToolStripMenuItem.Name = "enquiryToolStripMenuItem";
            this.enquiryToolStripMenuItem.Size = new System.Drawing.Size(88, 46);
            this.enquiryToolStripMenuItem.Text = "Enquiry";
            // 
            // bookEnquiryToolStripMenuItem
            // 
            this.bookEnquiryToolStripMenuItem.Name = "bookEnquiryToolStripMenuItem";
            this.bookEnquiryToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.bookEnquiryToolStripMenuItem.Text = "Book Enquiry";
            this.bookEnquiryToolStripMenuItem.Click += new System.EventHandler(this.bookEnquiryToolStripMenuItem_Click);
            // 
            // LMS_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.menuStrip1);
            this.Name = "LMS_Home";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem maintenaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enquiryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookEnquiryToolStripMenuItem;
    }
}

