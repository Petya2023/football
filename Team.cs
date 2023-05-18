using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }
        public double AveragePlayerAge
        {
            get
            {
                if (Players.Count == 0)
                    return 0;

                int totalAge = 0;
                foreach (var player in Players)
                {
                    totalAge += player.Age;
                }

                return (double)totalAge / Players.Count;
            }
        }
    }
}
