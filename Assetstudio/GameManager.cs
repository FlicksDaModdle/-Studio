using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace AssetStudio
{
    public static class GameManager
    {
        private static Dictionary<int, Game> Games = new Dictionary<int, Game>();
        static GameManager()
        {
            int count = 0;
            foreach (Type type in
                Assembly.GetAssembly(typeof(Game)).GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Game))))
            {
                var format = (Game)Activator.CreateInstance(type);
                Games.Add(count++, format);
            }
        }
        public static Game GetGame(int index)
        {
            if (!Games.TryGetValue(index, out var format))
            {
                throw new ArgumentException("Invalid format !!");
            }

            return format;
        }

        public static Game GetGame(string name)
        {
            foreach(var game in Games)
            {
                if (game.Value.Name == name)
                    return game.Value;
            }

            return null;
        }
        public static Game[] GetGames() => Games.Values.ToArray();
        public static string[] GetGameNames() => Games.Values.Select(x => x.Name).ToArray();
        public static string SupportedGames() => $"Supported Games:\n{string.Join("\n", Games.Values.Select(x => $"{x.Name} ({x.DisplayName})"))}";
        public static string ToString() => string.Join("\n", Games.Values);
    }

    public abstract class Game
    {
        public string Name;
        public string DisplayName;
        public string Extension;
        public string MapName;
        public string Path;
        public override string ToString() => DisplayName;
    }

    public class 1 : Game
    {
        public 1()
        {
            Name = "1";
            DisplayName = "1";
            MapName = "BLKMap";
            Extension = ".blk";
            Path = "GenshinImpact_Data|Yuanshen_Data";
        }
    }
    public class 2 : Game
    {
        public 2()
        {
            Name = "2";
            DisplayName = "2";
            MapName = "WMVMap";
            Extension = ".wmv";
            Path = "BH3_Data";
        }
    }
    public class 3 : Game
    {
        public 3()
        {
            Name = "3";
            DisplayName = "3";
            MapName = "ENCRMap";
            Extension = ".unity3d";
            Path = "StarRail_Data";
        }
    }
    public class 4 : Game
    {
        public 4()
        {
            Name = "4";
            DisplayName = "4";
            MapName = "TOTMap";
            Extension = ".blk";
            Path = "AssetbundlesCache";
        }
    }
    public class 5 : Game
    {
        public 5()
        {
            Name = "5";
            DisplayName = "5";
            MapName = "ZZZMap";
            Extension = ".bundle";
            Path = "Win_Data/StreamingAssets/Bundles";
        }
    }
}
