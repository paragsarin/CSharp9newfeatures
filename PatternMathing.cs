using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9newfeatures
{
    class PatternMatching
    {
        public double Temp { get; init; }
        public string City { get; init; }
        public string Summary { get; set; }
        public PatternMatching(double temp,string city)
        {
            Temp = temp;
            City = city;
            Summary = "";
        }
        //relation patterns > < >= <=
        //logical pattern(range) and or not 
        public static void ShowSummary(List<PatternMatching> summary)
        {
            foreach (var temp in summary)
            {
                /*  
                  if (temp.Temp < 0)
                  {
                      temp.Summary = "Super Cold";
                  }
                  else if (temp.Temp > 50)
                  {
                      temp.Summary = "Super Hot";
                  }
                  else if (temp.Temp > 30 && temp.Temp <50)
                  {
                      temp.Summary = "Hot";
                  }
                  else
                  {
                      temp.Summary = "I can live with it";
                  }
                */
                temp.Summary = temp.Temp switch
                {
                    < 0 => "Super Cold",
                    > 50 => "Super Hot",
                    > 30 and < 50 => "Hot",
                    _ => "I can live with it"
                };

            }
        }
    }
}
