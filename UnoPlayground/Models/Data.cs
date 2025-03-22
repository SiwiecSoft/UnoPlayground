using Bogus;
using UnoPlayground.Models.Bogus;
using Image = UnoPlayground.Models.Bogus.Image;

namespace UnoPlayground.Models;

public class Data
{
    public DataModel One { get; init; }
    public List<DataModel> List10 { get; init; }
    public List<DataModel> List100 { get; init; }

    public Data()
    {
        var faker = new Faker<DataModel>()
            .RuleFor(x => x.Address, f => new Address().Faker.Generate())
            .RuleFor(x => x.Commerce, f => new Commerce().Faker.Generate())
            .RuleFor(x => x.Company, f => new Company().Faker.Generate())
            .RuleFor(x => x.Date, f => new Date().Faker.Generate())
            .RuleFor(x => x.Finance, f => new Finance().Faker.Generate())
            .RuleFor(x => x.Image, f => new Image().Faker.Generate())
            .RuleFor(x => x.Internet, f => new Internet().Faker.Generate())
            .RuleFor(x => x.Name, f => new Name().Faker.Generate())
            .RuleFor(x => x.Number, f => new Number().Faker.Generate())
            .RuleFor(x => x.Text, f => new Text().Faker.Generate())
            .RuleFor(x => x.Vehicle, f => new Vehicle().Faker.Generate());

        One =       faker.Generate();
        List10 =    faker.Generate(10).ToList();
        List100 =   faker.Generate(100).ToList();
    }
}

public class DataModel
{
    public AddressModel Address { get; set; }
    public CommerceModel Commerce { get; set; }
    public CompanyModel Company { get; set; }
    public DateModel Date { get; set; }
    public FinanceModel Finance { get; set; }
    public ImageModel Image { get; set; }
    public InternetModel Internet { get; set; }
    public NameModel Name { get; set; }
    public NumberModel Number { get; set; }
    public TextModel Text { get; set; }
    public VehicleModel Vehicle { get; set; }
}
