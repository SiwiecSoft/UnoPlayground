using Bogus;

namespace UnoPlayground.Models.Bogus;

public class Company
{
    public Faker<CompanyModel> Faker { get; init; }

    public Company()
    {
        Faker = new Faker<CompanyModel>()
            .RuleFor(x => x.CompanySuffix, f => f.Company.CompanySuffix())
            .RuleFor(x => x.CompanyName, f => f.Company.CompanyName())
            .RuleFor(x => x.CatchPhrase, f => f.Company.CatchPhrase())
            .RuleFor(x => x.Bs, f => f.Company.Bs());
    }
}

public class CompanyModel
{
    public string CompanySuffix { get; set; }
    public string CompanyName { get; set; }
    public string CatchPhrase { get; set; }
    public string Bs { get; set; }
}
