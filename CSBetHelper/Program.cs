using System;

namespace CSBetHelper
{
    class Program
    {
        private static string dbFolder = "../../../Database/";
        private static string fileName = "Demo.xml";

        static void Main(string[] args)
        {
            var reader = new BetReaderFromXml();
            var bets = reader.ReadData(dbFolder + fileName);

            var betsStat = new BetStatistic(bets);
            Console.WriteLine(betsStat.ToString());
            
            var matchStatistic = new MatchStatistic(bets);
            Console.WriteLine(matchStatistic.ToString());

            //string newFile = "temp.xml";
            //var writer = new BetWriter();
            //writer.WriteBets(newFile, bets);
        }
    }
}
