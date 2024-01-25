using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    public class MarkdownFormatStrategy : ITextFormatStrategy
    {
        public string Format(string text)
        {
            return $"**{text}**";
        }
    }
}
