using System.Drawing;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SomeAlgos.Filter_Qualified_Players
{
    /// <summary>
    /// Exercise description:
    //   Implement the GetQualifiedPlayers method that takes a dictionary of player names and their scores.
    //   Your goal is to build a list of players who qualify for the next round based on the following rules:
    //   A player must have a score of at least 50 to qualify.
    //   If a player has a score of 100 or more, the process should stop immediately—this may indicate suspected cheating or a system rule violation.
    //   However, any players who qualified before this point should still be included in the result.
    //   Return the list of names of players who qualified before any disqualifying score was encountered.
    /// </summary>


    public class Player
    {
        public static List<string> GetQualifiedPlayers(Dictionary<string, int> playerScores)
        {
            const int disqualifyForCheating = 100;
            const int qualifyThreshold = 50;

            List<string> qualified = new List<string>();

            foreach (var player in playerScores)
            {
                switch (player.Value)
                {
                    case >= disqualifyForCheating:
                        return qualified; // Stop processing further players

                    case >= qualifyThreshold:
                        qualified.Add(player.Key);
                        break;

                    default:
                        // score < 50 – do nothing
                        break;
                }
            }

            return qualified;
        }

        public static List<string> GetQualifiedPlayersLinq(Dictionary<string, int> playerScores)
        {
            const int disqualifyForCheating = 100;
            const int qualifyThreshold = 50;

            return playerScores.TakeWhile(playerScore => playerScore.Value < disqualifyForCheating)
                               .Where(playerScore => playerScore.Value >= qualifyThreshold)
                               .Select(playerScore => playerScore.Key)
                               .ToList();
        }
    }
}
