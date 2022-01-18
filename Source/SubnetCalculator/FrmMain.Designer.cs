using System;
using System.Windows.Forms;

namespace SubnetCalculator
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.iacSourceIP = new IPAddressControlLib.IPAddressControl();
            this.label2 = new System.Windows.Forms.Label();
            this.iacSourceSubnet = new IPAddressControlLib.IPAddressControl();
            this.cmbSourceSubnet = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.btnClassA = new System.Windows.Forms.Button();
            this.btnClassB = new System.Windows.Forms.Button();
            this.btnClassC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // iacSourceIP
            // 
            this.iacSourceIP.AllowInternalTab = false;
            this.iacSourceIP.AutoHeight = true;
            this.iacSourceIP.BackColor = System.Drawing.SystemColors.Window;
            this.iacSourceIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.iacSourceIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iacSourceIP.Location = new System.Drawing.Point(69, 12);
            this.iacSourceIP.MinimumSize = new System.Drawing.Size(111, 25);
            this.iacSourceIP.Name = "iacSourceIP";
            this.iacSourceIP.ReadOnly = false;
            this.iacSourceIP.Size = new System.Drawing.Size(126, 25);
            this.iacSourceIP.TabIndex = 1;
            this.iacSourceIP.Text = "192.168.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Subnet";
            // 
            // iacSourceSubnet
            // 
            this.iacSourceSubnet.AllowInternalTab = false;
            this.iacSourceSubnet.AutoHeight = true;
            this.iacSourceSubnet.BackColor = System.Drawing.SystemColors.Window;
            this.iacSourceSubnet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.iacSourceSubnet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iacSourceSubnet.Location = new System.Drawing.Point(69, 43);
            this.iacSourceSubnet.MinimumSize = new System.Drawing.Size(111, 25);
            this.iacSourceSubnet.Name = "iacSourceSubnet";
            this.iacSourceSubnet.ReadOnly = true;
            this.iacSourceSubnet.Size = new System.Drawing.Size(126, 25);
            this.iacSourceSubnet.TabIndex = 1;
            this.iacSourceSubnet.TabStop = false;
            this.iacSourceSubnet.Text = "192.168.0.1";
            // 
            // cmbSourceSubnet
            // 
            this.cmbSourceSubnet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSourceSubnet.FormattingEnabled = true;
            this.cmbSourceSubnet.Location = new System.Drawing.Point(201, 44);
            this.cmbSourceSubnet.Name = "cmbSourceSubnet";
            this.cmbSourceSubnet.Size = new System.Drawing.Size(42, 25);
            this.cmbSourceSubnet.TabIndex = 2;
            this.cmbSourceSubnet.SelectedIndexChanged += new System.EventHandler(this.cmbSourceSubnet_SelectedIndexChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(261, 12);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(79, 97);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(346, 16);
            this.txbResult.Multiline = true;
            this.txbResult.Name = "txbResult";
            this.txbResult.ReadOnly = true;
            this.txbResult.Size = new System.Drawing.Size(370, 93);
            this.txbResult.TabIndex = 4;
            this.txbResult.TabStop = false;
            // 
            // btnClassA
            // 
            this.btnClassA.Location = new System.Drawing.Point(42, 78);
            this.btnClassA.Name = "btnClassA";
            this.btnClassA.Size = new System.Drawing.Size(63, 31);
            this.btnClassA.TabIndex = 5;
            this.btnClassA.Text = "A Class";
            this.btnClassA.UseVisualStyleBackColor = true;
            this.btnClassA.Click += new System.EventHandler(this.btnClassA_Click);
            // 
            // btnClassB
            // 
            this.btnClassB.Location = new System.Drawing.Point(111, 78);
            this.btnClassB.Name = "btnClassB";
            this.btnClassB.Size = new System.Drawing.Size(63, 31);
            this.btnClassB.TabIndex = 5;
            this.btnClassB.Text = "B Class";
            this.btnClassB.UseVisualStyleBackColor = true;
            this.btnClassB.Click += new System.EventHandler(this.btnClassB_Click);
            // 
            // btnClassC
            // 
            this.btnClassC.Location = new System.Drawing.Point(180, 78);
            this.btnClassC.Name = "btnClassC";
            this.btnClassC.Size = new System.Drawing.Size(63, 31);
            this.btnClassC.TabIndex = 5;
            this.btnClassC.Text = "C Class";
            this.btnClassC.UseVisualStyleBackColor = true;
            this.btnClassC.Click += new System.EventHandler(this.btnClassC_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 121);
            this.Controls.Add(this.btnClassC);
            this.Controls.Add(this.btnClassB);
            this.Controls.Add(this.btnClassA);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.cmbSourceSubnet);
            this.Controls.Add(this.iacSourceSubnet);
            this.Controls.Add(this.iacSourceIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Subnet Calculator";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private IPAddressControlLib.IPAddressControl ipAddressControl1;
        private IPAddressControlLib.IPAddressControl iacSourceIP;
        private Label label2;
        private IPAddressControlLib.IPAddressControl iacSourceSubnet;
        private ComboBox cmbSourceSubnet;
        private Button btnCalc;
        private TextBox txbResult;
        private Button btnClassA;
        private Button btnClassB;
        private Button btnClassC;
    }
}