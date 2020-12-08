using System.Collections.Generic;
using System.Linq;

namespace CodingTools.BlueDot
{
    public class FoodLog
    {
        public int Calories { get; set; }
        public string EatingDate { get; set; }
        public string EatingTime { get; set; }
        public string Food { get; set; }

        public static List<FoodLog> Logs = new List<FoodLog> {
            new FoodLog { Calories=1000, EatingDate="Jul 1", EatingTime="11 am", Food="Fried Chicken"},
            new FoodLog { Calories=1000, EatingDate="Jul 1", EatingTime="1 pm", Food="Bubble Tea"},
            new FoodLog { Calories=1000, EatingDate="Jul 1", EatingTime="3 pm", Food="Spaghetti"},
            new FoodLog { Calories=500, EatingDate="Jul 2", EatingTime="10 am", Food="Salad"},
            new FoodLog { Calories=500, EatingDate="Jul 2", EatingTime="4 pm", Food="Pork Chop"},
            new FoodLog { Calories=400, EatingDate="Jul 4", EatingTime="9 am", Food="Hamburger"},
        };
    }

    public class Solution
    {
        public string[] solution(int topX)
        {
            var groupedList = FoodLog.Logs.GroupBy(x => x.EatingDate).Select(logs => string.Format("{0},{1}", logs.First().EatingDate, logs.Sum(log => log.Calories))).Take(topX).ToArray();

            return groupedList;
        }
    }
}
