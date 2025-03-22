using Bogus;

namespace UnoPlayground.Models.Bogus;

public class Name
{
    public Faker<NameModel> Faker { get; init; }

    public Name()
    {
        Faker = new Faker<NameModel>()
            .RuleFor(x => x.FirstName, f => f.Name.FirstName())
            .RuleFor(x => x.LastName, f => f.Name.LastName())
            .RuleFor(x => x.FullName, f => f.Name.FullName())
            .RuleFor(x => x.Prefix, f => f.Name.Prefix())
            .RuleFor(x => x.Suffix, f => f.Name.Suffix())
            .RuleFor(x => x.FindName, f => f.Name.FindName())
            .RuleFor(x => x.JobTitle, f => f.Name.JobTitle())
            .RuleFor(x => x.JobDescriptor, f => f.Name.JobDescriptor())
            .RuleFor(x => x.JobArea, f => f.Name.JobArea())
            .RuleFor(x => x.JobType, f => f.Name.JobType());
    }
}

public class NameModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; set; }
    public string Prefix { get; set; }
    public string Suffix { get; set; }
    public string FindName { get; set; }
    public string JobTitle { get; set; }
    public string JobDescriptor { get; set; }
    public string JobArea { get; set; }
    public string JobType { get; set; }
}
