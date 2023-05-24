using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUGSHAKER
{
    internal class Program
    {
        public static void Main()
        {
            var thug = new THUG
            {
                Age = 23,
                Gender = true,
                Nationality = "Ethiopia",
                TotalGifs = 192,
                HipSizeCM = 130,
                WaistSizeCM = 80
            };
            Console.WriteLine(thug.Introduce);
            Console.WriteLine(thug.IntroduceThug);
            Console.ReadLine();
        }

        public class PERSON
        {
            public int Age { get; set; }
            public bool Gender { get; set; }
            public string Nationality { get; set; }

            public string Introduce => $"Hi, I'm {Age} years old and from {Nationality}.";
        }

        public class THUG : PERSON
        {
            public int TotalGifs { get; set; }
            public int HipSizeCM { get; set; }
            public int WaistSizeCM { get; set; }

            public string IntroduceThug => $"My hips size is {HipSizeCM}cm, my waist size is {WaistSizeCM}cm and I have {TotalGifs} gifs.";
        }
    }
}
