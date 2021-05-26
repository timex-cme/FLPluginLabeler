using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace PluginNamer
{
    public class DatabaseEntries : List<DatabaseEntry>
    {
        public string PluginDatabaseFolder => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"Image-Line\FL Studio\Presets\Plugin database");

        public void FindEntries(string rootPath)
        {
            FindEntries_internal(Path.Combine(rootPath, "Effects"));
            FindEntries_internal(Path.Combine(rootPath, "Generators"));
        }

        private void FindEntries_internal(string rootPath)
        {
            var directories = Directory.GetDirectories(rootPath);
            var files = Directory.GetFiles(rootPath, "*.nfo");

            foreach (var fileName in files)
            {
                Add(new DatabaseEntry(fileName));
            }

            foreach (var directory in directories)
            {
                FindEntries_internal(directory);
            }
        }

        public void ProcessEntries(int fontSize)
        {
            var sb = new StringBuilder();

            foreach (var entry in this)
            {
                try
                {

                    entry.ProcessEntry(fontSize);
                }
                catch (Exception ex)
                {
                    sb.AppendLine(entry.PluginName + ":" + ex.Message);
                }
            }

            if (sb.Length > 0)
            {
                throw new Exception(sb.ToString());
            }
        }
    }
}
