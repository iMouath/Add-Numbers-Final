namespace Add_Numbers_Final
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.enterWeightTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shimsLB = new System.Windows.Forms.ListBox();
            this.totalTB = new System.Windows.Forms.TextBox();
            this.chimsCount = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.countToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.clearLastEntryButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bagSizeLabel = new System.Windows.Forms.Label();
            this.bagSizeTB = new System.Windows.Forms.TextBox();
            this.saveBagSize = new System.Windows.Forms.Button();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.amountDue = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Weight:";
            // 
            // enterWeightTB
            // 
            this.enterWeightTB.Location = new System.Drawing.Point(317, 191);
            this.enterWeightTB.Margin = new System.Windows.Forms.Padding(2);
            this.enterWeightTB.Name = "enterWeightTB";
            this.enterWeightTB.Size = new System.Drawing.Size(82, 20);
            this.enterWeightTB.TabIndex = 1;
            this.enterWeightTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterWeightTB_CheckEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total:";
            // 
            // shimsLB
            // 
            this.shimsLB.FormattingEnabled = true;
            this.shimsLB.Location = new System.Drawing.Point(317, 31);
            this.shimsLB.Margin = new System.Windows.Forms.Padding(2);
            this.shimsLB.Name = "shimsLB";
            this.shimsLB.Size = new System.Drawing.Size(82, 134);
            this.shimsLB.TabIndex = 5;
            // 
            // totalTB
            // 
            this.totalTB.Location = new System.Drawing.Point(318, 168);
            this.totalTB.Margin = new System.Windows.Forms.Padding(2);
            this.totalTB.Name = "totalTB";
            this.totalTB.ReadOnly = true;
            this.totalTB.Size = new System.Drawing.Size(81, 20);
            this.totalTB.TabIndex = 6;
            // 
            // chimsCount
            // 
            this.chimsCount.AutoSize = true;
            this.chimsCount.Location = new System.Drawing.Point(137, 117);
            this.chimsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chimsCount.Name = "chimsCount";
            this.chimsCount.Size = new System.Drawing.Size(0, 13);
            this.chimsCount.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.countToolStrip,
            this.toolStripStatusLabel3,
            this.amountDue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 253);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(414, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(133, 17);
            this.toolStripStatusLabel1.Text = "Individual Shims Count:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // countToolStrip
            // 
            this.countToolStrip.Name = "countToolStrip";
            this.countToolStrip.Size = new System.Drawing.Size(13, 17);
            this.countToolStrip.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 39);
            this.label5.TabIndex = 12;
            this.label5.Text = "Please Enter the weight of your shim, then press enter to add it\r\nThe application" +
    " will keep record and calculate a running total.\r\nYou will have the option to pr" +
    "int a label and start a new entry.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 203);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Complete and Print Label";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearLastEntryButton
            // 
            this.clearLastEntryButton.Location = new System.Drawing.Point(148, 203);
            this.clearLastEntryButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearLastEntryButton.Name = "clearLastEntryButton";
            this.clearLastEntryButton.Size = new System.Drawing.Size(74, 37);
            this.clearLastEntryButton.TabIndex = 14;
            this.clearLastEntryButton.Text = "Clear Last Entry";
            this.clearLastEntryButton.UseVisualStyleBackColor = true;
            this.clearLastEntryButton.Click += new System.EventHandler(this.clearLastEntryButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(317, 217);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(82, 23);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(414, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "mainMenu";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addHelpToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // addHelpToolStripMenuItem
            // 
            this.addHelpToolStripMenuItem.Name = "addHelpToolStripMenuItem";
            this.addHelpToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addHelpToolStripMenuItem.Text = "Adding Chims";
            this.addHelpToolStripMenuItem.Click += new System.EventHandler(this.addHelpToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(147, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // bagSizeLabel
            // 
            this.bagSizeLabel.AutoSize = true;
            this.bagSizeLabel.Location = new System.Drawing.Point(9, 117);
            this.bagSizeLabel.Name = "bagSizeLabel";
            this.bagSizeLabel.Size = new System.Drawing.Size(86, 13);
            this.bagSizeLabel.TabIndex = 17;
            this.bagSizeLabel.Text = "Set the bag size:";
            // 
            // bagSizeTB
            // 
            this.bagSizeTB.Location = new System.Drawing.Point(101, 114);
            this.bagSizeTB.Name = "bagSizeTB";
            this.bagSizeTB.Size = new System.Drawing.Size(66, 20);
            this.bagSizeTB.TabIndex = 18;
            this.bagSizeTB.Text = "5.0";
            this.bagSizeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterSizeTB_CheckEnter);
            // 
            // saveBagSize
            // 
            this.saveBagSize.Location = new System.Drawing.Point(173, 112);
            this.saveBagSize.Name = "saveBagSize";
            this.saveBagSize.Size = new System.Drawing.Size(60, 23);
            this.saveBagSize.TabIndex = 19;
            this.saveBagSize.Text = "Save";
            this.saveBagSize.UseVisualStyleBackColor = true;
            this.saveBagSize.Click += new System.EventHandler(this.saveBagSize_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(144, 17);
            this.toolStripStatusLabel3.Text = "Amount till bundle is full: ";
            // 
            // amountDue
            // 
            this.amountDue.Name = "amountDue";
            this.amountDue.Size = new System.Drawing.Size(13, 17);
            this.amountDue.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 275);
            this.Controls.Add(this.saveBagSize);
            this.Controls.Add(this.bagSizeTB);
            this.Controls.Add(this.bagSizeLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.clearLastEntryButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chimsCount);
            this.Controls.Add(this.totalTB);
            this.Controls.Add(this.shimsLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enterWeightTB);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(430, 314);
            this.Name = "Form1";
            this.Text = "Add Shims";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enterWeightTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox shimsLB;
        private System.Windows.Forms.TextBox totalTB;
        private System.Windows.Forms.Label chimsCount;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripStatusLabel countToolStrip;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clearLastEntryButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label bagSizeLabel;
        private System.Windows.Forms.TextBox bagSizeTB;
        private System.Windows.Forms.Button saveBagSize;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel amountDue;
    }
}

