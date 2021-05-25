using System.Drawing;
using System.IO;

namespace PluginNamer
{
    public class DatabaseEntry
    {
        public string PluginName => Path.GetFileNameWithoutExtension(NfoFileName);
        public string PluginPath => Path.GetDirectoryName(NfoFileName);
        public string NfoFileName { get; private set; }
        public string BitmapFileName { get; private set; }

        public string BitmapPath => Path.Combine(PluginPath, BitmapFileName);
        public string ModifiedBitmapPath => Path.Combine(PluginPath, Path.GetFileNameWithoutExtension(BitmapFileName) + "_mod.png");

        public DatabaseEntry(string nfoFileName)
        {
            NfoFileName = nfoFileName;
        }

        public void ProcessEntry(int fontSize)
        {
            ModifyNfoFile();
            if (BitmapFileName != null)
            {
                using (var bm = new Bitmap(BitmapPath))
                {
                    using (var g = Graphics.FromImage(bm))
                    {
                        using (var font = new Font("Segoe UI", fontSize, GraphicsUnit.Pixel))
                        {
                            var caption = PluginName.Replace("Fruity ", ""); //shorten some entries
                            var size = g.MeasureString(caption, font);

                            //center text
                            float left = (float)((bm.Width - size.Width) / 2.0);

                            //left align if text does not fit entirely
                            if (left < 2.0)
                            {
                                left = 2.0f;
                            }

                            //draw shadow
                            g.DrawString(caption, font, Brushes.Black, new PointF(left - 2, bm.Height - size.Height - 2));
                            g.DrawString(caption, font, Brushes.Black, new PointF(left + 2, bm.Height - size.Height - 2));
                            g.DrawString(caption, font, Brushes.Black, new PointF(left, bm.Height - size.Height - 4));
                            g.DrawString(caption, font, Brushes.Black, new PointF(left, bm.Height - size.Height));

                            //draw plugin name
                            g.DrawString(caption, font, Brushes.White, new PointF(left, bm.Height - size.Height - 2));
                        }
                    }

                    bm.Save(ModifiedBitmapPath, System.Drawing.Imaging.ImageFormat.Png);
                    File.SetAttributes(ModifiedBitmapPath, FileAttributes.Hidden); //bitmap needs to be hidden
                }
            }
        }

        private void ModifyNfoFile()
        {
            const string identifier = "Bitmap=";
            const string modifiedId = "_mod"; //added to bitmap file name in nfo file

            var content = File.ReadAllText(NfoFileName);
            string line;
            bool found = false;

            BitmapFileName = null;

            using (var sr = new StringReader(content))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith(identifier)) //search for line starting with "Bitmap="
                    {
                        found = true;
                        break;
                    }
                }
            }

            if (found)
            {
                BitmapFileName = line.Substring(identifier.Length).Replace(modifiedId + ".png", ".png"); //always set filename of unmodified bitmap

                content = content.Replace(identifier + BitmapFileName, identifier + PluginName + modifiedId + ".png"); //replace "Bitmap=xyz.png" with "Bitmap=xyz_mod.png"
                File.Delete(NfoFileName); //not deleting file yields in access violation doring WriteAllText
                File.WriteAllText(NfoFileName, content);
                File.SetAttributes(NfoFileName, FileAttributes.Hidden); //file needs to be hidden
            }
        }
    }
}
