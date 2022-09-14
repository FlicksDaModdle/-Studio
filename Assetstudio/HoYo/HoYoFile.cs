using System;
using System.IO;
using System.Collections.Generic;

namespace AssetStudio
{
    public class HoYoFile
    {
        public Dictionary<long, StreamFile[]> Bundles = new Dictionary<long, StreamFile[]>();

        public HoYoFile(FileReader reader)
        {
            var bundles = new Dictionary<long, StreamFile[]>();
            var ext = Path.GetExtension(reader.FileName);
            switch (reader.Game.Name)
            {
                case "1":
                    var gi = GameManager.GetGame("1");
                    if (ext != gi.Extension)
                        goto default;

                    var blkFile = new BlkFile(reader);
                    bundles = blkFile.Bundles;
                    break;
                case "2":
                    var bh3 = GameManager.GetGame("2");
                    if (ext != bh3.Extension)
                        goto default;

                    Mr0k.ExpansionKey = Crypto.BH3ExpansionKey;
                    Mr0k.Key = Crypto.BH3Key;
                    Mr0k.ConstKey = Crypto.BH3ConstKey;
                    Mr0k.SBox = Crypto.BH3SBox;
                    Mr0k.BlockKey = null;

                    var wmvFile = new WMVFile(reader);
                    bundles = wmvFile.Bundles;
                    break;
                case "5":
                    var zzz = GameManager.GetGame("5");
                    if (ext != zzz.Extension)
                        goto default;

                    Mr0k.ExpansionKey = Crypto.ExpansionKey;
                    Mr0k.Key = Crypto.Key;
                    Mr0k.ConstKey = Crypto.ConstKey;
                    Mr0k.SBox = null;
                    Mr0k.BlockKey = null;

                    var zzzFile = new BundleFile(reader);
                    bundles.Add(0, zzzFile.FileList);
                    break;
                case "3":
                    var sr = GameManager.GetGame("3");
                    if (ext != sr.Extension)
                        goto default;

                    Mr0k.ExpansionKey = Crypto.ExpansionKey;
                    Mr0k.Key = Crypto.Key;
                    Mr0k.ConstKey = Crypto.ConstKey;
                    Mr0k.SBox = null;
                    Mr0k.BlockKey = null;

                    var srFile = new BundleFile(reader);
                    bundles.Add(0, srFile.FileList);
                    break;
                case "4":
                    var tot = GameManager.GetGame("4");
                    if (ext != tot.Extension)
                        goto default;

                    Mr0k.ExpansionKey = Crypto.ExpansionKey;
                    Mr0k.Key = Crypto.Key;
                    Mr0k.ConstKey = Crypto.ConstKey;
                    Mr0k.SBox = null;
                    Mr0k.BlockKey = Crypto.BlockKey;

                    var totFile = new TOTFile(reader);
                    bundles = totFile.Bundles;
                    break;
                default:
                    throw new NotSupportedException("File not supported !!\nMake sure to select the right game before loading the file");
            }
            Bundles = bundles;
        }
    }
}
