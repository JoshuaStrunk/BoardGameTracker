using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoardGameTracker.Models
{
    public class BoardGame
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PlayTime { get; set; }
        public int YearPublished { get; set; }
        public List<string> Designers { get; set; }
        public List<string> Type { get; set; }
        public List<string> Mechanics { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlyaers { get; set; }
    }
}