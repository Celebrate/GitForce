﻿namespace git4win.FormOptions_Panels
{
    partial class ControlAliases
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxAliases = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxAliases
            // 
            this.textBoxAliases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAliases.Location = new System.Drawing.Point(0, 0);
            this.textBoxAliases.Multiline = true;
            this.textBoxAliases.Name = "textBoxAliases";
            this.textBoxAliases.Size = new System.Drawing.Size(300, 300);
            this.textBoxAliases.TabIndex = 0;
            // 
            // ControlAliases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxAliases);
            this.Name = "ControlAliases";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAliases;
    }
}
