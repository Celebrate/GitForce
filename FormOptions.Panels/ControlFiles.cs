﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace git4win.FormOptions_Panels
{
    public partial class ControlFiles : UserControl, IUserSettings
    {
        public ControlFiles()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialize pertinent settings
        /// </summary>
        /// <param name="options">All git global settings</param>
        public void Init(string[] options)
        {
            string value = ClassConfig.Get("core.ignorecase");
            checkBoxIgnoreCase.Checked = (value.ToLower() == "true") ? true : false;
            checkBoxShowDotGit.Checked = Properties.Settings.Default.ShowDotGitFolders;

            // Add the dirty (modified) value changed helper
            checkBoxIgnoreCase.CheckStateChanged += ControlDirtyHelper.ControlDirty;
            checkBoxShowDotGit.CheckStateChanged += ControlDirtyHelper.ControlDirty;
        }

        /// <summary>
        /// Apply changed settings
        /// </summary>
        public void ApplyChanges()
        {
            if (checkBoxIgnoreCase.Tag != null)
            {
                ClassConfig.Set("core.ignorecase", checkBoxIgnoreCase.Checked.ToString());
                checkBoxIgnoreCase.Tag = null;
            }

            Properties.Settings.Default.ShowDotGitFolders = checkBoxShowDotGit.Checked;
        }
    }
}