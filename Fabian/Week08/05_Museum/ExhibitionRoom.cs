﻿
using static Fabian.Selftest_SP.TowersOfHanoi;
namespace Fabian.Week08._05_Museum
{
    public class ExhibitionRoom : Room
    {
        private Random rnd = new Random();
        private List<Artwork> _Artworks;
        public List<Artwork> Artworks { get => _Artworks; set => _Artworks = value; }
        public ExhibitionRoom(string name) : base(name)
        { 
            _Artworks = new List<Artwork>();
        }

        protected override void PrintMyself(string prefix)
        {
            Console.Write($"{prefix} Exhibition: {_Name}");
        }

        public override void PrintAction(Visitor v)
        {
            int random = rnd.Next(_Artworks.Count);
            Console.Write($"{v.Name} is spectating the \"");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(_Artworks[random].Name);
            Console.ResetColor();
            Console.WriteLine($"\" artwork in the {_Name}");
        }
    }
}
