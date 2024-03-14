using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class House
    {
        public List<string> Parts { get; private set; } = new List<string>();
        public void AddPart(string part) => Parts.Add(part);
        public void ShowHause()
        {
            Console.WriteLine("\nHouse Parts -------");
            foreach (string part in Parts)
            {
                Console.WriteLine(part);
            }
        }

    }
}
