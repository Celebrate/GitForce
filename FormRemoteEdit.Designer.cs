﻿namespace git4win
{
    partial class FormRemoteEdit
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
            this.btDone = new System.Windows.Forms.Button();
            this.userControlRemoteEdit = new git4win.RemoteEdit();
            this.SuspendLayout();
            // 
            // btDone
            // 
            this.btDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btDone.Location = new System.Drawing.Point(456, 187);
            this.btDone.Name = "btDone";
            this.btDone.Size = new System.Drawing.Size(75, 23);
            this.btDone.TabIndex = 1;
            this.btDone.Text = "Done";
            this.btDone.UseVisualStyleBackColor = true;
            // 
            // userControlRemoteEdit
            // 
            this.userControlRemoteEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlRemoteEdit.Location = new System.Drawing.Point(12, 12);
            this.userControlRemoteEdit.MinimumSize = new System.Drawing.Size(320, 165);
            this.userControlRemoteEdit.Name = "userControlRemoteEdit";
            this.userControlRemoteEdit.Size = new System.Drawing.Size(519, 171);
            this.userControlRemoteEdit.TabIndex = 0;
            // 
            // FormRemoteEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 222);
            this.Controls.Add(this.btDone);
            this.Controls.Add(this.userControlRemoteEdit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(388, 260);
            this.Name = "FormRemoteEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Remote Repositories";
            this.ResumeLayout(false);

        }

        #endregion

        private RemoteEdit userControlRemoteEdit;
        private System.Windows.Forms.Button btDone;

    }
}