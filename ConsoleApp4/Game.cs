using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Game
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public int ReleaseYear { get; set; }
        public int Price { get; set; }
        public double Rating { get; set; }
        public Game(string name, string genre, string publisher, int releaseYear, int price, double rating)
        {
            Name = name;
            Genre = genre;
            Publisher = publisher;
            ReleaseYear = releaseYear;
            Price = price;
            Rating = rating;
        }
        public Game(string line)
        {
            string[] data = line.Split(';');
            Name = data[0];
            Genre = data[1];
            Publisher = data[2];
            ReleaseYear = int.Parse(data[3]);
            Price = int.Parse(data[4]);
            Rating = double.Parse(data[5]);
        }
        public override string ToString()
        {
            return $"Name: {Name} | Genre: {Genre} | Publisher: {Publisher} | Release Year: {ReleaseYear} | Price: {Price} | Rating: {Rating}";
        }
    }
}
