namespace Akhil_TreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Core Java");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Advanced Java");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Java", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("C#");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Programming", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Oracle");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Hadoop");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Cloud");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("DataBases", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("MSBI");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("EDI");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Reporting", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Selenium");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Manual");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Cucumber");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("UFT");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Appeium");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Testing", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Android");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("IOS");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Mobile Apps", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.treeView1.Location = new System.Drawing.Point(34, 115);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node7";
            treeNode1.Text = "Core Java";
            treeNode2.Name = "Node8";
            treeNode2.Text = "Advanced Java";
            treeNode3.Name = "Node5";
            treeNode3.Text = "Java";
            treeNode4.Name = "Node6";
            treeNode4.Text = "C#";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Programming";
            treeNode6.Name = "Node9";
            treeNode6.Text = "Oracle";
            treeNode7.Name = "Node10";
            treeNode7.Text = "Hadoop";
            treeNode8.Name = "Node11";
            treeNode8.Text = "Cloud";
            treeNode9.Name = "Node1";
            treeNode9.Text = "DataBases";
            treeNode10.Name = "Node12";
            treeNode10.Text = "MSBI";
            treeNode11.Name = "Node13";
            treeNode11.Text = "EDI";
            treeNode12.Name = "Node2";
            treeNode12.Text = "Reporting";
            treeNode13.Name = "Node14";
            treeNode13.Text = "Selenium";
            treeNode14.Name = "Node15";
            treeNode14.Text = "Manual";
            treeNode15.Name = "Node16";
            treeNode15.Text = "Cucumber";
            treeNode16.Name = "Node17";
            treeNode16.Text = "UFT";
            treeNode17.Name = "Node18";
            treeNode17.Text = "Appeium";
            treeNode18.Name = "Node3";
            treeNode18.Text = "Testing";
            treeNode19.Name = "Node19";
            treeNode19.Text = "Android";
            treeNode20.Name = "Node20";
            treeNode20.Text = "IOS";
            treeNode21.Name = "Node4";
            treeNode21.Text = "Mobile Apps";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9,
            treeNode12,
            treeNode18,
            treeNode21});
            this.treeView1.Size = new System.Drawing.Size(181, 421);
            this.treeView1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.treeView1, "Select any Course");
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(249, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tree View";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(279, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course Name:";
            this.toolTip1.SetToolTip(this.label2, "your course name");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(455, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 3;
            this.toolTip1.SetToolTip(this.label3, "Your Selected Course is displayed");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 577);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

