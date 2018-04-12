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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Weight:";
            // 
            // enterWeightTB
            // 
            this.enterWeightTB.Location = new System.Drawing.Point(423, 235);
            this.enterWeightTB.Name = "enterWeightTB";
            this.enterWeightTB.Size = new System.Drawing.Size(108, 22);
            this.enterWeightTB.TabIndex = 1;
            this.enterWeightTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterWeightTB_CheckEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total:";
            // 
            // shimsLB
            // 
            this.shimsLB.FormattingEnabled = true;
            this.shimsLB.ItemHeight = 16;
            this.shimsLB.Location = new System.Drawing.Point(423, 38);
            this.shimsLB.Name = "shimsLB";
            this.shimsLB.Size = new System.Drawing.Size(108, 164);
            this.shimsLB.TabIndex = 5;
            // 
            // totalTB
            // 
            this.totalTB.Location = new System.Drawing.Point(424, 207);
            this.totalTB.Name = "totalTB";
            this.totalTB.ReadOnly = true;
            this.totalTB.Size = new System.Drawing.Size(107, 22);
            this.totalTB.TabIndex = 6;
            // 
            // chimsCount
            // 
            this.chimsCount.AutoSize = true;
            this.chimsCount.Location = new System.Drawing.Point(172, 210);
            this.chimsCount.Name = "chimsCount";
            this.chimsCount.Size = new System.Drawing.Size(0, 17);
            this.chimsCount.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.countToolStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 276);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(540, 25);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(163, 20);
            this.toolStripStatusLabel1.Text = "Individual Shims Count:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 20);
            // 
            // countToolStrip
            // 
            this.countToolStrip.Name = "countToolStrip";
            this.countToolStrip.Size = new System.Drawing.Size(17, 20);
            this.countToolStrip.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(405, 85);
            this.label5.TabIndex = 12;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Complete and Print Label";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 45);
            this.button2.TabIndex = 14;
            this.button2.Text = "Clear Last Entry";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 301);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chimsCount);
            this.Controls.Add(this.totalTB);
            this.Controls.Add(this.shimsLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enterWeightTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Add Shims";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.Button button2;
    }
}

