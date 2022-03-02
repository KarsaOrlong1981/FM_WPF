using FM_WPF.Models;
using System;

namespace FM_WPF
{

    public static class PlayerGenerator
    {
        private static Random random = new Random();
        private static int Defense { get; set; }
        private static int Midfield { get; set; }
        private static int Attack  { get; set; }
        private static int GoalKeeper { get; set; }
        public static Player CreateNewPlayer(string league, string club, string position)
        {
            Player player = new Player();
            player = SetPlayerAttributes(player, league, club,position);
            return player;
        }
        private static Player SetPlayerAttributes(Player player, string league, string club, string position)
        {
            
            string foreName = string.Empty;
            string sureName = string.Empty;
            switch (league)
            {
                case "Germany":
                    foreName = NameGenerator.GetGermanForeName();
                    sureName = NameGenerator.GetGermanSureName();
                    break;
                case "England":

                    break;
            }
            player.Forename = foreName;
            player.Surname = sureName;
            player.Position = position;
            player.Age = random.Next(16, 35);
            player.ActualClub = club;
            player.Weigth = random.Next(65, 85);
            double size = random.NextDouble() * (2.00 - 1.65) + 1.65;
            player.Size = Math.Round(size, 2);
           
            GetClubspezificAtt(club, random, position, GoalKeeper,Defense, Midfield, Attack, player);  
          
            return player;
        }


        #region Position Attributes
        private static void GetClubspezificAtt(string club, Random random, string position, int goalkeeper, int defense, int midfield, int attack, Player player)
        {
            
            switch (club)
            {
                case "Kaiserslautern": GetAttributeForPos(position, 50, 75, random, 30, 60, goalkeeper, defense, midfield, attack, player); break;
            }
            
        }
        private static void GetAttributeForPos(string position, int minPosition, int maxPosition, Random random, int minOther, int maxOther,int goalkeeper, int defense, int midfield, int attack, Player player)
        {
            switch (position)
            {
                case "Defense":
                    goalkeeper = random.Next(20, 50);
                    defense = random.Next(minPosition, maxPosition); 
                    midfield = random.Next(minOther, maxOther);
                    attack = random.Next(minOther, maxOther);
                    break;
                case "Midfield":
                    goalkeeper = random.Next(20, 50);
                    defense = random.Next(minOther, maxOther);
                    midfield = random.Next(minPosition, maxPosition);
                    attack = random.Next(minOther, maxOther);
                    break;
                case "Attack":
                    goalkeeper = random.Next(20, 50);
                    defense = random.Next(minOther, maxOther);
                    midfield = random.Next(minOther, maxOther);
                    attack = random.Next(minPosition, maxPosition);
                    break;
                case "Goalkeeper":
                    goalkeeper = random.Next(minPosition, maxPosition);
                    defense = random.Next(20, 50);
                    midfield = random.Next(20, 50);
                    attack = random.Next(20, 50);
                    break;
            }
            player.Goalkeeping = goalkeeper;
            player.Defense = defense;
            player.Midfield = midfield; 
            player.Attack = attack;
            

        }
        #endregion // Position Attributes
    }
}
