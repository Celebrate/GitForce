﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace git4win
{
    /// <summary>
    /// Class containing a set of remotes for a given repository
    /// This class mainly manages names and passwords - things that
    /// are not kept natively with a git repo
    /// </summary>
    [Serializable]
    public class ClassRemotes
    {
        /// <summary>
        /// Structure describing a remote repo. Only the name and password are
        /// to be used across the sessions, while the URL fields gets rewritten
        /// every time the list of remotes is updated from git
        /// </summary>
        [Serializable]
        public struct Remote
        {
            public string name;
            public string urlFetch;
            public string urlPush;
            public string password;
        }

        /// <summary>
        /// Current (default) remote name
        /// </summary>
        public string current = "";

        /// <summary>
        /// Lookup dictionary of passwords for a given remote name
        /// Implicitly, it also stores the list of remotes
        /// </summary>
        private Dictionary<string, Remote> remotes = new Dictionary<string, Remote>();

        /// <summary>
        /// Return the list<> of names of remote repos
        /// </summary>
        public List<string> GetListNames()
        {
            List<string> list = remotes.Select(kvp => kvp.Key).ToList();
            return list;
        }

        /// <summary>
        /// Return the remote structure associated with a given name
        /// </summary>
        public Remote Get(string name)
        {
            return remotes[name];
        }

        /// <summary>
        /// Refresh the list of remotes for the given repo while keeping the
        /// existing passwords
        /// </summary>
        public void Refresh(ClassRepo repo)
        {
            // Build the new list while picking up password fields from the existing list
            Dictionary<string, Remote> newlist = new Dictionary<string, Remote>();

            string[] response = repo.Run("remote -v").Split(("\n").ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in response)
            {
                Remote r = new Remote();

                // Split the resulting remote repo name/url into separate strings
                string[] url = s.Split("\t ".ToCharArray());
                string name = url[0];

                // Find if the name exists in the main list and save off the password from it
                if (newlist.ContainsKey(name))
                    r = newlist[name];

                if (remotes.ContainsKey(name))
                    r.password = remotes[name].password;

                // Set all other fields that we refresh every time                
                r.name = name;

                if (url[2] == "(fetch)") r.urlFetch = url[1];
                if (url[2] == "(push)") r.urlPush = url[1];

                // Add it to the new list
                newlist[name] = r;
            }

            // Set the newly built list to be the master list
            remotes = newlist;

            // Fixup the new current string name
            if (!remotes.ContainsKey(current))
                current = remotes.Count > 0 ? remotes.ElementAt(0).Key : "";
        }

        /// <summary>
        /// Sets the password field for the given remote name or
        /// creates a new remote if the named one does not exist
        /// </summary>
        public void SetPassword(string name, string password)
        {
            Remote r = new Remote();
            if (!remotes.TryGetValue(name, out r))
                r.name = name;
            r.password = password;
            remotes[name] = r;
        }

        /// <summary>
        /// Return the password for a given remote by name or
        /// the current remote (if name is empty string)
        /// </summary>
        public string GetPassword(string name="")
        {
            Remote r = new Remote();
            r.password = "";
            if (name == "") name = current;
            remotes.TryGetValue(name, out r);
            return r.password;
        }
    }
}
