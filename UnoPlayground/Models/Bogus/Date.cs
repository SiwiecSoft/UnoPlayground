using Bogus;

namespace UnoPlayground.Models.Bogus;

public class Date
{
    public Faker<DateModel> Faker { get; init; }

    public Date()
    {
        Faker = new Faker<DateModel>()
            .RuleFor(x => x.Past, f => f.Date.Past())
            .RuleFor(x => x.PastOffset, f => f.Date.PastOffset())
            .RuleFor(x => x.Soon, f => f.Date.Soon())
            .RuleFor(x => x.SoonOffset, f => f.Date.SoonOffset())
            .RuleFor(x => x.Future, f => f.Date.Future())
            .RuleFor(x => x.FutureOffset, f => f.Date.FutureOffset())
            .RuleFor(x => x.Recent, f => f.Date.Recent())
            .RuleFor(x => x.RecentOffset, f => f.Date.RecentOffset())
            .RuleFor(x => x.Timespan, f => f.Date.Timespan())
            .RuleFor(x => x.Month, f => f.Date.Month())
            .RuleFor(x => x.Weekday, f => f.Date.Weekday());
    }
}

public class DateModel
{
    public DateTime Past { get; set; }
    public DateTimeOffset PastOffset { get; set; }
    public DateTime Soon { get; set; }
    public DateTimeOffset SoonOffset { get; set; }
    public DateTime Future { get; set; }
    public DateTimeOffset FutureOffset { get; set; }
    public DateTime Recent { get; set; }
    public DateTimeOffset RecentOffset { get; set; }
    public TimeSpan Timespan { get; set; }
    public string Month { get; set; }
    public string Weekday { get; set; }
}
