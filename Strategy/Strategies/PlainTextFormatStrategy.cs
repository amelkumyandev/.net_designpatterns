namespace Strategy.Strategies
{
    public class PlainTextFormatStrategy : ITextFormatStrategy
    {
        public string Format(string text)
        {
            return text;
        }
    }

}
