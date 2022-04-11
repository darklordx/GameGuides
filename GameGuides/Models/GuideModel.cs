using System;
using System.Collections.Generic;

namespace GameGuides.Models
{
    public class GuideModel
    {
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

        public static List<GuideModel> getGuides()
        {
            return new List<GuideModel>{
                new GuideModel("Tic Tac Toe", "Use X and O boi", "Win pls")
            };
        }

    }
}