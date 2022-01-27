using System;
using System.Linq;
using System.Xml.Linq;

namespace mastermind
{
    public enum Colour
    {
        Red,
        Blue,
        Green,
        Orange,
        Purple,
        Yellow
    }

    public static class ColourExtensions
    {
        public static Colour[] GetColour()
        {
            return new Colour[]
            {
                Colour.Red,
                Colour.Blue,
                Colour.Green,
                Colour.Orange,
                Colour.Purple,
                Colour.Yellow
            };
        }
    }
}