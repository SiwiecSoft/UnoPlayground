using Bogus;

namespace UnoPlayground.Models.Bogus;

public class Text
{
    public Faker<TextModel> Faker { get; init; }

    public Text()
    {
        Faker = new Faker<TextModel>()
            .RuleFor(x => x.Word, f => f.Lorem.Word())
            .RuleFor(x => x.Words2, f => string.Join(" ", f.Lorem.Words(2)))
            .RuleFor(x => x.Words5, f => string.Join(" ", f.Lorem.Words(5)))
            .RuleFor(x => x.Words10, f => string.Join(" ", f.Lorem.Words(10)))
            .RuleFor(x => x.Words20, f => string.Join(" ", f.Lorem.Words(20)))
            .RuleFor(x => x.Words50, f => string.Join(" ", f.Lorem.Words(50)))
            .RuleFor(x => x.Words100, f => string.Join(" ", f.Lorem.Words(100)))
            .RuleFor(x => x.Words200, f => string.Join(" ", f.Lorem.Words(200)))
            .RuleFor(x => x.Words500, f => string.Join(" ", f.Lorem.Words(500)))
            .RuleFor(x => x.Words1000, f => string.Join(" ", f.Lorem.Words(1000)))

            .RuleFor(x => x.Sentence, f => f.Lorem.Sentence())
            .RuleFor(x => x.Paragraph, f => f.Lorem.Paragraph())
            .RuleFor(x => x.Line, f => f.Lorem.Lines(1))
            .RuleFor(x => x.Text, f => f.Lorem.Text())
            .RuleFor(x => x.Slug, f => f.Lorem.Slug())

            /*.RuleFor(x => x.Sentences2, f => f.Lorem.Sentences(2))
            .RuleFor(x => x.Sentences5, f => f.Lorem.Sentences(5))
            .RuleFor(x => x.Sentences10, f => f.Lorem.Sentences(10))
            .RuleFor(x => x.Sentences20, f => f.Lorem.Sentences(20))
            .RuleFor(x => x.Paragraphs2, f => f.Lorem.Paragraphs(2))
            .RuleFor(x => x.Paragraphs5, f => f.Lorem.Paragraphs(5))
            .RuleFor(x => x.Paragraphs10, f => f.Lorem.Paragraphs(10))
            .RuleFor(x => x.Paragraphs20, f => f.Lorem.Paragraphs(20))
            .RuleFor(x => x.Lines2, f => f.Lorem.Lines(2))
            .RuleFor(x => x.Lines5, f => f.Lorem.Lines(5))
            .RuleFor(x => x.Lines10, f => f.Lorem.Lines(10))
            .RuleFor(x => x.Lines20, f => f.Lorem.Lines(20))*/
            ;
    }
}

public class TextModel
{
    public string Word { get; set; }
    public string Words2 { get; set; }
    public string Words5 { get; set; }
    public string Words10 { get; set; }
    public string Words20 { get; set; }
    public string Words50 { get; set; }
    public string Words100 { get; set; }
    public string Words200 { get; set; }
    public string Words500 { get; set; }
    public string Words1000 { get; set; }

    public string Sentence { get; set; }
    public string Paragraph { get; set; }
    public string Line { get; set; }
    public string Text { get; set; }
    public string Slug { get; set; }

    public string Sentences2 { get; set; }
    public string Sentences5 { get; set; }
    public string Sentences10 { get; set; }
    public string Sentences20 { get; set; }

    public string Paragraphs2 { get; set; }
    public string Paragraphs5 { get; set; }
    public string Paragraphs10 { get; set; }
    public string Paragraphs20 { get; set; }

    public string Lines2 { get; set; }
    public string Lines5 { get; set; }
    public string Lines10 { get; set; }
    public string Lines20 { get; set; }
}
