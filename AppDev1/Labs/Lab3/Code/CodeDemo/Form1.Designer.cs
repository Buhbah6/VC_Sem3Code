﻿
namespace CodeDemo
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
            this.myButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myButton
            // 
            this.myButton.Location = new System.Drawing.Point(248, 99);
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(100, 42);
            this.myButton.TabIndex = 0;
            this.myButton.Text = "Click Me!";
            this.myButton.UseVisualStyleBackColor = true;
            this.myButton.Click += new System.EventHandler(this.myButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 286);
            this.Controls.Add(this.myButton);
            this.Name = "Form1";
            this.Text = "Code Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button myButton;
    }
}

