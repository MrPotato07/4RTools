﻿namespace _4RTools.Forms
{
    partial class Container
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Container));
            this.lblProcessName = new System.Windows.Forms.Label();
            this.processCB = new System.Windows.Forms.ComboBox();
            this.chckToggle = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblLinkDiscord = new System.Windows.Forms.LinkLabel();
            this.lblLinkGithub = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.Location = new System.Drawing.Point(562, 85);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(126, 13);
            this.lblProcessName.TabIndex = 3;
            this.lblProcessName.Text = "Ragnarok Process Name";
            // 
            // processCB
            // 
            this.processCB.FormattingEnabled = true;
            this.processCB.Location = new System.Drawing.Point(514, 101);
            this.processCB.Name = "processCB";
            this.processCB.Size = new System.Drawing.Size(173, 21);
            this.processCB.TabIndex = 2;
            this.processCB.SelectedIndexChanged += new System.EventHandler(this.processCB_SelectedIndexChanged);
            // 
            // chckToggle
            // 
            this.chckToggle.AutoSize = true;
            this.chckToggle.Location = new System.Drawing.Point(565, 128);
            this.chckToggle.Name = "chckToggle";
            this.chckToggle.Size = new System.Drawing.Size(123, 17);
            this.chckToggle.TabIndex = 4;
            this.chckToggle.Text = "Enabled (Tecla End)";
            this.chckToggle.UseVisualStyleBackColor = true;
            this.chckToggle.CheckedChanged += new System.EventHandler(this.chckToggle_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(491, 100);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(19, 22);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 267);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(679, 225);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(671, 199);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(671, 199);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblLinkDiscord
            // 
            this.lblLinkDiscord.AutoSize = true;
            this.lblLinkDiscord.Location = new System.Drawing.Point(595, 219);
            this.lblLinkDiscord.Name = "lblLinkDiscord";
            this.lblLinkDiscord.Size = new System.Drawing.Size(92, 13);
            this.lblLinkDiscord.TabIndex = 8;
            this.lblLinkDiscord.TabStop = true;
            this.lblLinkDiscord.Text = "Join in our discord";
            this.lblLinkDiscord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkDiscord_LinkClicked);
            // 
            // lblLinkGithub
            // 
            this.lblLinkGithub.AutoSize = true;
            this.lblLinkGithub.Location = new System.Drawing.Point(613, 184);
            this.lblLinkGithub.Name = "lblLinkGithub";
            this.lblLinkGithub.Size = new System.Drawing.Size(74, 13);
            this.lblLinkGithub.TabIndex = 9;
            this.lblLinkGithub.TabStop = true;
            this.lblLinkGithub.Text = "Github Project";
            this.lblLinkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkGithub_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Location = new System.Drawing.Point(558, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(31, 33);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel2.Location = new System.Drawing.Point(578, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 33);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(15, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 56);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(433, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 242);
            this.panel4.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Profile";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(514, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLinkGithub);
            this.Controls.Add(this.lblLinkDiscord);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.chckToggle);
            this.Controls.Add(this.lblProcessName);
            this.Controls.Add(this.processCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Container";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4ROTools - Versão Beta";
            this.Load += new System.EventHandler(this.Container_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.ComboBox processCB;
        private System.Windows.Forms.CheckBox chckToggle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.LinkLabel lblLinkDiscord;
        private System.Windows.Forms.LinkLabel lblLinkGithub;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}