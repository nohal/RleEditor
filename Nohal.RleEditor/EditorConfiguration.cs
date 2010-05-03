#region License Details
// --------------------------------------------------------------------------------------------
// This file is part of RleEditor.
// 
//     RleEditor is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     RleEditor is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with RleEditor.  If not, see <http://www.gnu.org/licenses/>.
// --------------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Text;

namespace Nohal.RleEditor
{
    public class EditorConfiguration
    {
        public string S57Folder { get; set; }
        public string LastUsedFile { get; set; }
        public bool OpenLastUsedOnStartup { get; set; }
        public bool AutoSortLupts { get; set; }
        public string FileHeader { get; set; }

        public void Save()
        {
            Configuration cfg = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            cfg.AppSettings.Settings.Clear();
            cfg.AppSettings.Settings.Add("S57Folder", S57Folder);
            cfg.AppSettings.Settings.Add("LastUsedFile", LastUsedFile);
            cfg.AppSettings.Settings.Add("OpenLastUsedOnStartup", OpenLastUsedOnStartup.ToString());
            cfg.AppSettings.Settings.Add("AutoSortLupts", AutoSortLupts.ToString());
            cfg.AppSettings.Settings.Add("FileHeader", FileHeader);
            cfg.Save(ConfigurationSaveMode.Full);
        }

        public void Load()
        {
            try
            {
                S57Folder = ConfigurationManager.AppSettings["S57Folder"];
                LastUsedFile = ConfigurationManager.AppSettings["LastUsedFile"];
                OpenLastUsedOnStartup = Convert.ToBoolean(ConfigurationManager.AppSettings["OpenLastUsedOnStartup"]);
                AutoSortLupts = Convert.ToBoolean(ConfigurationManager.AppSettings["AutoSortLupts"]);
                FileHeader = ConfigurationManager.AppSettings["FileHeader"];
            }
            catch (Exception ex)
            {
                Debug.Print("Exception {0} while loading configuration", ex.Message);
            }
        }
    }
}
