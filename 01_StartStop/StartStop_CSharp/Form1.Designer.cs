namespace Cust01
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
            this.chkEdge = new System.Windows.Forms.CheckBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.cmdAppend = new System.Windows.Forms.Button();
            this.cmdVersion = new System.Windows.Forms.Button();
            this.cmdHide = new System.Windows.Forms.Button();
            this.cmdShow = new System.Windows.Forms.Button();
            this.cmdStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkEdge
            // 
            this.chkEdge.AutoSize = true;
            this.chkEdge.Location = new System.Drawing.Point(12, 317);
            this.chkEdge.Name = "chkEdge";
            this.chkEdge.Size = new System.Drawing.Size(107, 17);
            this.chkEdge.TabIndex = 42;
            this.chkEdge.Text = "Display Edge Bar";
            this.chkEdge.UseVisualStyleBackColor = true;
            this.chkEdge.CheckedChanged += new System.EventHandler(this.chkEdge_CheckedChanged);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(12, 294);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(112, 17);
            this.chkStatus.TabIndex = 41;
            this.chkStatus.Text = "Display Status Bar";
            this.chkStatus.UseVisualStyleBackColor = true;
            this.chkStatus.CheckedChanged += new System.EventHandler(this.chkStatus_CheckedChanged);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(12, 215);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(138, 20);
            this.txtStatus.TabIndex = 40;
            this.txtStatus.Text = "www.cadvertex.com";
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(12, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 15);
            this.label1.TabIndex = 39;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmdQuit
            // 
            this.cmdQuit.Location = new System.Drawing.Point(12, 353);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(138, 38);
            this.cmdQuit.TabIndex = 38;
            this.cmdQuit.Text = "Quit Solid Edge";
            this.cmdQuit.UseVisualStyleBackColor = true;
            this.cmdQuit.Click += new System.EventHandler(this.cmdQuit_Click);
            // 
            // cmdAppend
            // 
            this.cmdAppend.Location = new System.Drawing.Point(12, 241);
            this.cmdAppend.Name = "cmdAppend";
            this.cmdAppend.Size = new System.Drawing.Size(138, 38);
            this.cmdAppend.TabIndex = 35;
            this.cmdAppend.Text = "Append to Status bar";
            this.cmdAppend.UseVisualStyleBackColor = true;
            this.cmdAppend.Click += new System.EventHandler(this.cmdAppend_Click);
            // 
            // cmdVersion
            // 
            this.cmdVersion.Location = new System.Drawing.Point(12, 135);
            this.cmdVersion.Name = "cmdVersion";
            this.cmdVersion.Size = new System.Drawing.Size(138, 38);
            this.cmdVersion.TabIndex = 34;
            this.cmdVersion.Text = "Display Version";
            this.cmdVersion.UseVisualStyleBackColor = true;
            this.cmdVersion.Click += new System.EventHandler(this.cmdVersion_Click);
            // 
            // cmdHide
            // 
            this.cmdHide.Location = new System.Drawing.Point(87, 82);
            this.cmdHide.Name = "cmdHide";
            this.cmdHide.Size = new System.Drawing.Size(63, 38);
            this.cmdHide.TabIndex = 37;
            this.cmdHide.Text = "Hide";
            this.cmdHide.UseVisualStyleBackColor = true;
            this.cmdHide.Click += new System.EventHandler(this.cmdHide_Click);
            // 
            // cmdShow
            // 
            this.cmdShow.Location = new System.Drawing.Point(12, 82);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(69, 38);
            this.cmdShow.TabIndex = 36;
            this.cmdShow.Text = "Show";
            this.cmdShow.UseVisualStyleBackColor = true;
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(12, 12);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(138, 50);
            this.cmdStart.TabIndex = 33;
            this.cmdStart.Text = "Start Solid Edge";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 404);
            this.Controls.Add(this.chkEdge);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.cmdAppend);
            this.Controls.Add(this.cmdVersion);
            this.Controls.Add(this.cmdHide);
            this.Controls.Add(this.cmdShow);
            this.Controls.Add(this.cmdStart);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Solid Edge: CSharp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox chkEdge;
        internal System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdQuit;
        private System.Windows.Forms.Button cmdAppend;
        private System.Windows.Forms.Button cmdVersion;
        private System.Windows.Forms.Button cmdHide;
        private System.Windows.Forms.Button cmdShow;
        private System.Windows.Forms.Button cmdStart;
    }
}

