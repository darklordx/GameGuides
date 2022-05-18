using System;
using System.Collections.Generic;

namespace GameGuides.Models
{
    public class GuideModel
    {
        private const string TTTS = "When you're the first one up, there is a simple strategy on how to win tic tac toe: put your 'X' in any corner. This move will pretty much send you to the winner's circle every time, so long as your opponent doesn't put their first 'O' in the center box. This can make it harder to win, but it can happen.";
        private const string V = "The game is played on a grid that's 3 squares by 3 squares.";
        private const string V1 = "You are X, your friend (or the computer in this case) is O. Players take turns putting their marks in empty squares.";
        private const string V2 = "The first player to get 3 of her marks in a row (up, down, across, or diagonally) is the winner.";
        private const string V3 = "When all 9 squares are full, the game is over.";

        /*
* We can add more stuff if we want.
* 
* 
*/

        public string Title { get; set; }
        public string Rules { get; set; }
        public string Strategies { get; set; }

        public GuideModel(String t, String r, String s)
        {
            Title = t;
            Rules = r;
            Strategies = s;
        }

        public static List<GuideModel> getGuides() => new List<GuideModel>{
                new GuideModel("Tic Tac Toe", V+V1+V2+V3,TTTS),
                new GuideModel("Chess", "https://en.wikipedia.org/wiki/Rules_of_chess", "https://www.chess.com/terms/chess-strategy"),
                new GuideModel("Checkers", "https://www.ultraboardgames.com/checkers/game-rules.php", "https://www.thesprucecrafts.com/how-to-win-at-checkers-411170")
            };

    }
}