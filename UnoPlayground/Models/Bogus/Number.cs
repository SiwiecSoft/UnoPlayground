using Bogus;

namespace UnoPlayground.Models.Bogus;

public class Number
{
    public Faker<NumberModel> Faker { get; init; }

    public Number()
    {
        Faker = new Faker<NumberModel>()
            .RuleFor(x => x.Int0To100, f => f.Random.Int(0, 100))
            .RuleFor(x => x.Int0To1000, f => f.Random.Int(0, 1000))
            .RuleFor(x => x.Int0To10000, f => f.Random.Int(0, 10000))
            .RuleFor(x => x.Int10To100, f => f.Random.Int(10, 100))
            .RuleFor(x => x.Int100To1000, f => f.Random.Int(100, 1000))
            .RuleFor(x => x.IntMinus1000To1000, f => f.Random.Int(-1000, 1000))
            .RuleFor(x => x.Int1000To9999, f => f.Random.Int(1000, 9999))
            .RuleFor(x => x.Double0To1, f => f.Random.Double(0.0, 1.0))
            .RuleFor(x => x.DoubleMinus1000To1000, f => f.Random.Double(-1000.0, 1000.0))
            .RuleFor(x => x.Double0To1000, f => f.Random.Double(0.0, 1000.0))
            .RuleFor(x => x.Double0To1000000, f => f.Random.Double(0.0, 10000000.0))
            .RuleFor(x => x.Double100To1000, f => f.Random.Double(100.0, 1000.0))
            .RuleFor(x => x.Digit1, f => f.Random.ReplaceNumbers("#"))
            .RuleFor(x => x.Digit2, f => f.Random.ReplaceNumbers("##"))
            .RuleFor(x => x.Digit3, f => f.Random.ReplaceNumbers("###"))
            .RuleFor(x => x.Digit4, f => f.Random.ReplaceNumbers("####"))
            .RuleFor(x => x.Digit5, f => f.Random.ReplaceNumbers("#####"))
            .RuleFor(x => x.Digit6, f => f.Random.ReplaceNumbers("######"))
            .RuleFor(x => x.Digit7, f => f.Random.ReplaceNumbers("#######"))
            .RuleFor(x => x.Digit8, f => f.Random.ReplaceNumbers("########"))
            .RuleFor(x => x.Digit9, f => f.Random.ReplaceNumbers("#########"));
    }
}

public class NumberModel
{
    public int Int0To100 { get; set; }
    public int Int0To1000 { get; set; }
    public int Int0To10000 { get; set; }
    public int Int10To100 { get; set; }
    public int Int100To1000 { get; set; }
    public int IntMinus1000To1000 { get; set; }
    public int Int1000To9999 { get; set; }

    public double Double0To1 { get; set; }
    public double DoubleMinus1000To1000 { get; set; }
    public double Double0To1000 { get; set; }
    public double Double0To1000000 { get; set; }
    public double Double100To1000 { get; set; }

    public string Digit1 { get; set; }
    public string Digit2 { get; set; }
    public string Digit3 { get; set; }
    public string Digit4 { get; set; }
    public string Digit5 { get; set; }
    public string Digit6 { get; set; }
    public string Digit7 { get; set; }
    public string Digit8 { get; set; }
    public string Digit9 { get; set; }
}
