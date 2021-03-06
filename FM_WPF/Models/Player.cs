using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FM_WPF.Models
{
    public class Player
    {
        public int Id { get; set; }
        //Personality
        public string Avatar { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Foot { get; set; }
        public string ActualClub { get; set; }
        public string Position { get; set; }
        //Body
        public int Age { get; set; }
        public int Weigth { get; set; }
        public double Size { get; set; }
        //Strength
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int Midfield { get; set; }
        public int Attack { get; set; }

        public int BodyStrength { get; set; }
        public int Tactical { get; set; }

        public int TechnicSkill { get; set; }
        public int Header { get; set; }
        public int Shooting { get; set; }
        public int Flanks { get; set; }
        public int Passing { get; set; }
        public int Speed { get; set; }
        //Phsycho Attributtes
        public int Moral { get; set; }
        public int Talent { get; set; }
        public int Fitness { get; set; }
        public int Form { get; set; }
        //GoalKeeping
        public int Goalkeeping { get; set; }
        public int KickOff { get; set; }
        public int Positioning { get; set; }
    }
}
