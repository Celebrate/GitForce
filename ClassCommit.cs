﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace git4win
{
    /// <summary>
    /// Class describing and working on one commit
    /// A commit is a set of files grouped together under one node
    /// </summary>
    [Serializable]
    public class ClassCommit
    {
        public List<string> files = new List<string>();
        public string description = null;
        public bool isDefault = false;

        public ClassCommit(string desc)
        {
            description = desc;
        }

        /// <summary>
        /// Add a set of files to the commit list.
        /// Do not create any duplicates!
        /// </summary>
        public void AddFiles(List<string> newFiles)
        {
            files = files.Union(newFiles).ToList();
        }

        /// <summary>
        /// Remove all files listed from our list of files.
        /// Any file on that list may or may not appear on this commit list.
        /// </summary>
        public void Prune(List<string> outlaws)
        {
            files = files.Except(outlaws).ToList();
        }

        /// <summary>
        /// Renew the existing list of files by keeping only those that exist in the
        /// given list. Return the given list trimmed by files which are now "taken".
        /// </summary>
        public List<string> Renew(List<string> allFiles)
        {
            files = files.Intersect(allFiles).ToList();
            return allFiles.Except(files).ToList();
        }
    }
}
