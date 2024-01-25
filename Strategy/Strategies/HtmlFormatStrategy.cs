using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    public class HtmlFormatStrategy : ITextFormatStrategy
    {
        public string Format(string text)
        {
            return $"<p>{text}</p>";
        }
    }
}
