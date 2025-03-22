using Bogus;

namespace UnoPlayground.Models.Bogus;

public class Commerce
{
    public Faker<CommerceModel> Faker { get; init; }

    public Commerce()
    {
        Faker = new Faker<CommerceModel>()
            .RuleFor(x => x.Department, f => f.Commerce.Department())
            .RuleFor(x => x.Price, f => f.Commerce.Price())
            .RuleFor(x => x.Categories, f => f.Commerce.Categories(3))
            .RuleFor(x => x.ProductName, f => f.Commerce.ProductName())
            .RuleFor(x => x.Color, f => f.Commerce.Color())
            .RuleFor(x => x.Product, f => f.Commerce.Product())
            .RuleFor(x => x.ProductAdjective, f => f.Commerce.ProductAdjective())
            .RuleFor(x => x.ProductMaterial, f => f.Commerce.ProductMaterial())
            .RuleFor(x => x.Ean8, f => f.Commerce.Ean8())
            .RuleFor(x => x.Ean13, f => f.Commerce.Ean13());
    }
}

public class CommerceModel
{
    public string Department { get; set; }
    public string Price { get; set; }
    public IEnumerable<string> Categories { get; set; }
    public string ProductName { get; set; }
    public string Color { get; set; }
    public string Product { get; set; }
    public string ProductAdjective { get; set; }
    public string ProductMaterial { get; set; }
    public string Ean8 { get; set; }
    public string Ean13 { get; set; }
}
