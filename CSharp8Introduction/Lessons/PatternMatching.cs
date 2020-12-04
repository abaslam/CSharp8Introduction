using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Introduction.Lessons
{
    public class PatternMatching
    {
        public static void Run()
        {
            var color = FromRainbow(Rainbow.Blue);
            Console.WriteLine($"Red: {color.Red}, Green: {color.Green}, Blue: {color.Blue}");

            var salesTax = ComputeSalesTax(new Address { State = "WA" }, 100);
            Console.WriteLine($"Sales Tas: {salesTax}");

            var winner = RockPaperScissors("rock", "paper");
            Console.WriteLine($"Winner is:{winner}");

            var quadrant = GetQuadrant(new Lessons.Point(10, 10));
            Console.WriteLine($"Quadrant: {quadrant}");
        }


        public static RGBColor FromRainbow(Rainbow colorBand)
        {
            switch (colorBand)
            {
                case Rainbow.Red:
                    break;
                case Rainbow.Orange:
                    break;
                case Rainbow.Yellow:
                    break;
                case Rainbow.Green:
                    break;
                case Rainbow.Blue:
                    {

                    }
                    break;
                case Rainbow.Indigo:
                    break;
                case Rainbow.Violet:
                    break;
                default:
                    break;
            }

            return colorBand switch
            {
                Rainbow.Red => new RGBColor(0xFF, 0x00, 0x00),
                Rainbow.Orange => new RGBColor(0xFF, 0x7F, 0x00),
                Rainbow.Yellow => new RGBColor(0xFF, 0xFF, 0x00),
                Rainbow.Green => new RGBColor(0x00, 0xFF, 0x00),
                Rainbow.Blue => new RGBColor(0x00, 0x00, 0xFF),
                Rainbow.Indigo => new RGBColor(0x4B, 0x00, 0x82),
                Rainbow.Violet => new RGBColor(0x94, 0x00, 0xD3),
                _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
            };
        }

        public static decimal ComputeSalesTax(Address location, decimal salePrice)
        {
            //if(location.State== "WA")
            //{
            //    return salePrice * 0.06M;
            //}

            return location switch
            {
                { State: "WA" } => salePrice * 0.06M,
                { State: "MN" } => salePrice * 0.075M,
                { State: "MI" } => salePrice * 0.05M,
                _ => 0M
            };
        }
        public static string RockPaperScissors(string first, string second)
        {
            //if (first == "rock" && second == "paper")
            //{
            //    return "rock is covered by paper. Paper wins.";
            //}

            return (first, second) switch
            {
                ("rock", "paper") => "rock is covered by paper. Paper wins.",
                ("rock", "scissors") => "rock breaks scissors. Rock wins.",
                ("paper", "rock") => "paper covers rock. Paper wins.",
                ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
                ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
                ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
                (_, _) => "tie"
            };
        }

        public static Quadrant GetQuadrant(Point point) => point switch
        {
            (0, 0) => Quadrant.Origin,
            var (x, y) when x > 0 && y > 0 => Quadrant.One,
            var (x, y) when x < 0 && y > 0 => Quadrant.Two,
            var (x, y) when x < 0 && y < 0 => Quadrant.Three,
            var (x, y) when x > 0 && y < 0 => Quadrant.Four,
            var (_, _) => Quadrant.OnBorder,
            _ => Quadrant.Unknown
        };

    }

    public class Address
    {
        public string State { get; set; } = string.Empty;
        public string? Country { get; set; }

        public int Price { get; set; }
    }

    public enum Rainbow
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        Violet
    }

    public class RGBColor
    {
        public int Red;
        public int Green;
        public int Blue;

        public RGBColor(int red, int green, int blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }
    }

    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y) => (X, Y) = (x, y);

        public void Deconstruct(out int x, out int y) =>
            (x, y) = (X, Y);
    }

    public enum Quadrant
    {
        Unknown,
        Origin,
        One,
        Two,
        Three,
        Four,
        OnBorder
    }
}
