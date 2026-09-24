using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Model
    {
        public List<Game> games = new();
        private void Import()
        {
            games = File.ReadAllLines("games.txt").Select(x => new Game(x)).ToList();
        }
        public Model()
        {
            Import();
        }
        public Dictionary<string, int> PublisherCount()
        {
            return games.GroupBy(x => x.Publisher).ToDictionary(x => x.Key, y => y.Count());
        }
        public Dictionary<string, int> GenreCount()
        {
            return games.GroupBy(x => x.Genre).ToDictionary(x => x.Key, y => y.Count());
        }
        public Dictionary<string, double> GenreAvgRating()
        {
            return games.GroupBy(x => x.Genre).ToDictionary(x => x.Key, y => y.Average(z => z.Rating));
        }
        public Dictionary<string, double> PublisherMaxRating()
        {
            return games.GroupBy(x => x.Publisher).ToDictionary(x => x.Key, y => y.Max(z => z.Rating));
        }
        public Dictionary<string, string> ExpensiveGame()
        {
            return games.GroupBy(x => x.Genre).ToDictionary(x => x.Key, y => y.OrderByDescending(z => z.Price).Select(z => z.Name).First());
        }
        public List<string> PublisherMin4()
        {
            return games.GroupBy(x => x.Publisher).Where(x => x .Count() >= 4).Select(x => x.Key).ToList();
        }
        public Dictionary<string, double> PubliserAvgOrder()
        {
            return games.GroupBy(x => x.Publisher).OrderByDescending(x => x.Average(y => y.Rating)).ToDictionary(x => x.Key, y => y.Average(z => z.Rating));
        }
        public 
    }
}
