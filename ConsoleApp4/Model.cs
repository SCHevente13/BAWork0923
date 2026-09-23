using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
