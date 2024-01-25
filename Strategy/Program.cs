using Strategy;

TextProcessor processor = new TextProcessor(new Strategy.Strategies.PlainTextFormatStrategy());
Console.WriteLine(processor.Process("This is a plain text"));

processor.SetFormatStrategy(new Strategy.Strategies.HtmlFormatStrategy());
Console.WriteLine(processor.Process("This is an HTML text"));

processor.SetFormatStrategy(new Strategy.Strategies.MarkdownFormatStrategy());
Console.WriteLine(processor.Process("This is a Markdown text"));