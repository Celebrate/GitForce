﻿namespace git4win
{
    partial class FormDeleteRepo
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.radioDelete1 = new System.Windows.Forms.RadioButton();
            this.radioDelete2 = new System.Windows.Forms.RadioButton();
            this.radioDelete3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(285, 122);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btDelete.Location = new System.Drawing.Point(204, 122);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // radioDelete1
            // 
            this.radioDelete1.AutoSize = true;
            this.radioDelete1.Checked = true;
            this.radioDelete1.Location = new System.Drawing.Point(12, 50);
            this.radioDelete1.Name = "radioDelete1";
            this.radioDelete1.Size = new System.Drawing.Size(287, 17);
            this.radioDelete1.TabIndex = 2;
            this.radioDelete1.TabStop = true;
            this.radioDelete1.Tag = "0";
            this.radioDelete1.Text = "Only remove it from this git4win list. All files will be intact.";
            this.radioDelete1.UseVisualStyleBackColor = true;
            this.radioDelete1.Click += new System.EventHandler(this.radioButtonClicked);
            // 
            // radioDelete2
            // 
            this.radioDelete2.AutoSize = true;
            this.radioDelete2.Location = new System.Drawing.Point(12, 73);
            this.radioDelete2.Name = "radioDelete2";
            this.radioDelete2.Size = new System.Drawing.Size(263, 17);
            this.radioDelete2.TabIndex = 3;
            this.radioDelete2.Tag = "1";
            this.radioDelete2.Text = "Also delete .git directory, but leave your files intact.";
            this.radioDelete2.UseVisualStyleBackColor = true;
            this.radioDelete2.Click += new System.EventHandler(this.radioButtonClicked);
            // 
            // radioDelete3
            // 
            this.radioDelete3.AutoSize = true;
            this.radioDelete3.Location = new System.Drawing.Point(12, 96);
            this.radioDelete3.Name = "radioDelete3";
            this.radioDelete3.Size = new System.Drawing.Size(174, 17);
            this.radioDelete3.TabIndex = 4;
            this.radioDelete3.Tag = "2";
            this.radioDelete3.Text = "Delete .git directory and all files.";
            this.radioDelete3.UseVisualStyleBackColor = true;
            this.radioDelete3.Click += new System.EventHandler(this.radioButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Path:";
            // 
            // textPath
            // 
            this.textPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textPath.Enabled = false;
            this.textPath.Location = new System.Drawing.Point(50, 9);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(310, 20);
            this.textPath.TabIndex = 6;
            // 
            // FormDeleteRepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 157);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioDelete3);
            this.Controls.Add(this.radioDelete2);
            this.Controls.Add(this.radioDelete1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(361, 195);
            this.Name = "FormDeleteRepo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete Local Repository";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.RadioButton radioDelete1;
        private System.Windows.Forms.RadioButton radioDelete2;
        private System.Windows.Forms.RadioButton radioDelete3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPath;
    }
}