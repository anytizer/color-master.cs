﻿namespace colorrmaster
{
    public partial class Master: Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.foregroundButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolTipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyColorCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFullCSSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anytizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectSourceCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestAFeatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button6 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(84, 300);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(609, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.Location = new System.Drawing.Point(84, 351);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(609, 45);
            this.trackBar2.TabIndex = 5;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.AutoSize = false;
            this.trackBar3.Location = new System.Drawing.Point(84, 402);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(609, 45);
            this.trackBar3.TabIndex = 6;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "R";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "G";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 45);
            this.button3.TabIndex = 9;
            this.button3.Text = "B";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // foregroundButton
            // 
            this.foregroundButton.Location = new System.Drawing.Point(84, 105);
            this.foregroundButton.Name = "foregroundButton";
            this.foregroundButton.Size = new System.Drawing.Size(180, 186);
            this.foregroundButton.TabIndex = 12;
            this.foregroundButton.Text = "Profile";
            this.foregroundButton.UseVisualStyleBackColor = true;
            this.foregroundButton.Click += new System.EventHandler(this.foregroundButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(395, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 89);
            this.label1.TabIndex = 11;
            this.label1.Text = "#000000";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(270, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 51);
            this.label2.TabIndex = 13;
            this.label2.Text = "«";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(317, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 51);
            this.label3.TabIndex = 13;
            this.label3.Text = "»";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.Location = new System.Drawing.Point(270, 198);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(88, 39);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.randomizeToolStripMenuItem,
            this.cSSToolStripMenuItem,
            this.contactToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem,
            this.enableToolTipsToolStripMenuItem,
            this.animateToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always on Top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // enableToolTipsToolStripMenuItem
            // 
            this.enableToolTipsToolStripMenuItem.Name = "enableToolTipsToolStripMenuItem";
            this.enableToolTipsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.enableToolTipsToolStripMenuItem.Text = "Enable Tool Tips";
            this.enableToolTipsToolStripMenuItem.Click += new System.EventHandler(this.enableToolTipsToolStripMenuItem_Click);
            // 
            // animateToolStripMenuItem
            // 
            this.animateToolStripMenuItem.Name = "animateToolStripMenuItem";
            this.animateToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.animateToolStripMenuItem.Text = "Animate Randomizer";
            this.animateToolStripMenuItem.Click += new System.EventHandler(this.animateToolStripMenuItem_Click);
            // 
            // randomizeToolStripMenuItem
            // 
            this.randomizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forgroundColorToolStripMenuItem,
            this.backgroundColorToolStripMenuItem,
            this.bothToolStripMenuItem});
            this.randomizeToolStripMenuItem.Name = "randomizeToolStripMenuItem";
            this.randomizeToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.randomizeToolStripMenuItem.Text = "Randomize";
            // 
            // forgroundColorToolStripMenuItem
            // 
            this.forgroundColorToolStripMenuItem.Name = "forgroundColorToolStripMenuItem";
            this.forgroundColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.forgroundColorToolStripMenuItem.Text = "Forground Color";
            this.forgroundColorToolStripMenuItem.Click += new System.EventHandler(this.forgroundColorToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // bothToolStripMenuItem
            // 
            this.bothToolStripMenuItem.Name = "bothToolStripMenuItem";
            this.bothToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.bothToolStripMenuItem.Text = "Both";
            this.bothToolStripMenuItem.Click += new System.EventHandler(this.bothToolStripMenuItem_Click);
            // 
            // cSSToolStripMenuItem
            // 
            this.cSSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyColorCodeToolStripMenuItem,
            this.copyFullCSSToolStripMenuItem1});
            this.cSSToolStripMenuItem.Name = "cSSToolStripMenuItem";
            this.cSSToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.cSSToolStripMenuItem.Text = "CSS";
            // 
            // copyColorCodeToolStripMenuItem
            // 
            this.copyColorCodeToolStripMenuItem.Name = "copyColorCodeToolStripMenuItem";
            this.copyColorCodeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.copyColorCodeToolStripMenuItem.Text = "Copy Color Code";
            this.copyColorCodeToolStripMenuItem.Click += new System.EventHandler(this.copyColorCodeToolStripMenuItem_Click);
            // 
            // copyFullCSSToolStripMenuItem1
            // 
            this.copyFullCSSToolStripMenuItem1.Name = "copyFullCSSToolStripMenuItem1";
            this.copyFullCSSToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.copyFullCSSToolStripMenuItem1.Text = "Copy Full CSS";
            this.copyFullCSSToolStripMenuItem1.Click += new System.EventHandler(this.copyFullCSSToolStripMenuItem1_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anytizerToolStripMenuItem,
            this.projectSourceCodeToolStripMenuItem,
            this.requestAFeatureToolStripMenuItem});
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.contactToolStripMenuItem.Text = "Contact";
            // 
            // anytizerToolStripMenuItem
            // 
            this.anytizerToolStripMenuItem.Name = "anytizerToolStripMenuItem";
            this.anytizerToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.anytizerToolStripMenuItem.Text = "@anytizer";
            this.anytizerToolStripMenuItem.Click += new System.EventHandler(this.anytizerToolStripMenuItem_Click);
            // 
            // projectSourceCodeToolStripMenuItem
            // 
            this.projectSourceCodeToolStripMenuItem.Name = "projectSourceCodeToolStripMenuItem";
            this.projectSourceCodeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.projectSourceCodeToolStripMenuItem.Text = "Project Source Code";
            this.projectSourceCodeToolStripMenuItem.Click += new System.EventHandler(this.projectSourceCodeToolStripMenuItem_Click);
            // 
            // requestAFeatureToolStripMenuItem
            // 
            this.requestAFeatureToolStripMenuItem.Name = "requestAFeatureToolStripMenuItem";
            this.requestAFeatureToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.requestAFeatureToolStripMenuItem.Text = "Request a Feature";
            this.requestAFeatureToolStripMenuItem.Click += new System.EventHandler(this.requestAFeatureToolStripMenuItem_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkOrange;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(10, 198);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 91);
            this.button6.TabIndex = 16;
            this.button6.Text = "?";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(375, 200);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // backgroundButton
            // 
            this.backgroundButton.Location = new System.Drawing.Point(12, 27);
            this.backgroundButton.Name = "backgroundButton";
            this.backgroundButton.Size = new System.Drawing.Size(681, 170);
            this.backgroundButton.TabIndex = 19;
            this.backgroundButton.Text = "background";
            this.backgroundButton.UseVisualStyleBackColor = true;
            this.backgroundButton.Click += new System.EventHandler(this.backgroundButton_Click);
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 455);
            this.Controls.Add(this.foregroundButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backgroundButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Master";
            this.Text = "Colorr Master";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button backgroundButton;
        private Button foregroundButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem applicationToolStripMenuItem;
        private ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private ToolStripMenuItem contactToolStripMenuItem;
        private ToolStripMenuItem projectSourceCodeToolStripMenuItem;
        private ToolStripMenuItem anytizerToolStripMenuItem;
        private Button button6;
        private ToolStripMenuItem cSSToolStripMenuItem;
        private ToolStripMenuItem copyColorCodeToolStripMenuItem;
        private ToolStripMenuItem copyFullCSSToolStripMenuItem1;
        private CheckBox checkBox1;
        private ToolTip toolTip1;
        private ToolStripMenuItem enableToolTipsToolStripMenuItem;
        private ToolStripMenuItem requestAFeatureToolStripMenuItem;
        private ToolStripMenuItem randomizeToolStripMenuItem;
        private ToolStripMenuItem forgroundColorToolStripMenuItem;
        private ToolStripMenuItem backgroundColorToolStripMenuItem;
        private ToolStripMenuItem bothToolStripMenuItem;
        private ToolStripMenuItem animateToolStripMenuItem;
    }
}