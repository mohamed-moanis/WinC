﻿namespace WinC
{
    partial class FormInputPrompt
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(163, 30);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(257, 20);
            this.txtInput.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(45, 33);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 13);
            this.lbl.TabIndex = 2;
            // 
            // FormInputPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 108);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.button1);
            this.Name = "FormInputPrompt";
            this.Load += new System.EventHandler(this.frmInputPrompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lbl;
    }
}