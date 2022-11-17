using System;

namespace Asssignment02
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
            this.lstTo = new System.Windows.Forms.ListBox();
            this.lstFrom = new System.Windows.Forms.ListBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxFrom = new System.Windows.Forms.GroupBox();
            this.groupBoxTo = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lstTo
            // 
            this.lstTo.FormattingEnabled = true;
            this.lstTo.ItemHeight = 20;
            this.lstTo.Items.AddRange(new object[] {
            "Inches",
            "Feet ",
            "Yards"});
            this.lstTo.Location = new System.Drawing.Point(471, 167);
            this.lstTo.Name = "lstTo";
            this.lstTo.Size = new System.Drawing.Size(173, 184);
            this.lstTo.TabIndex = 2;
            this.lstTo.SelectedIndexChanged += new System.EventHandler(this.lstTo_SelectedIndexChanged);
            // 
            // lstFrom
            // 
            this.lstFrom.FormattingEnabled = true;
            this.lstFrom.ItemHeight = 20;
            this.lstFrom.Items.AddRange(new object[] {
            "Inches",
            "Feet ",
            "Yards"});
            this.lstFrom.Location = new System.Drawing.Point(186, 167);
            this.lstFrom.Name = "lstFrom";
            this.lstFrom.Size = new System.Drawing.Size(173, 184);
            this.lstFrom.TabIndex = 2;
            this.lstFrom.SelectedIndexChanged += new System.EventHandler(this.lstFrom_SelectedIndexChanged);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(182, 74);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(215, 20);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Enter a distance to convert:";
            this.lblInput.Click += new System.EventHandler(this.lblInput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(418, 67);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(162, 27);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(154, 447);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(162, 20);
            this.lblDistance.TabIndex = 4;
            this.lblDistance.Text = "Converted Distance:";
            this.lblDistance.Click += new System.EventHandler(this.lblDistance_Click);
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(362, 440);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(201, 27);
            this.txtDistance.TabIndex = 5;
            this.txtDistance.TextChanged += new System.EventHandler(this.txtDistance_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConvert.Location = new System.Drawing.Point(186, 490);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(112, 59);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.Location = new System.Drawing.Point(451, 490);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 59);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // groupBoxFrom
            // 
            this.groupBoxFrom.Location = new System.Drawing.Point(159, 140);
            this.groupBoxFrom.Name = "groupBoxFrom";
            this.groupBoxFrom.Size = new System.Drawing.Size(244, 242);
            this.groupBoxFrom.TabIndex = 7;
            this.groupBoxFrom.TabStop = false;
            this.groupBoxFrom.Text = "From";
            // 
            // groupBoxTo
            // 
            this.groupBoxTo.Location = new System.Drawing.Point(451, 140);
            this.groupBoxTo.Name = "groupBoxTo";
            this.groupBoxTo.Size = new System.Drawing.Size(223, 242);
            this.groupBoxTo.TabIndex = 8;
            this.groupBoxTo.TabStop = false;
            this.groupBoxTo.Text = "To";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lstFrom);
            this.Controls.Add(this.lstTo);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.groupBoxFrom);
            this.Controls.Add(this.groupBoxTo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTo;
        private System.Windows.Forms.ListBox lstFrom;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBoxFrom;
        private System.Windows.Forms.GroupBox groupBoxTo;
    }
}
