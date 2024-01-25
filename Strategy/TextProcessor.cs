using Strategy.Strategies;

namespace Strategy
{
    public class TextProcessor
    {
        private ITextFormatStrategy _formatStrategy;

        public TextProcessor(ITextFormatStrategy formatStrategy)
        {
            _formatStrategy = formatStrategy;
        }

        public void SetFormatStrategy(ITextFormatStrategy formatStrategy)
        {
            _formatStrategy = formatStrategy;
        }

        public string Process(string text)
        {
            return _formatStrategy.Format(text);
        }
    }

}
