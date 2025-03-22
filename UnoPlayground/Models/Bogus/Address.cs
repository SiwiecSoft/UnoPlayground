using Bogus;

namespace UnoPlayground.Models.Bogus;

public class Address
{
    public Faker<AddressModel> Faker { get; init; }

    public Address()
    {
        Faker = new Faker<AddressModel>()
            .RuleFor(x => x.ZipCode, f => f.Address.ZipCode())
            .RuleFor(x => x.City, f => f.Address.City())
            .RuleFor(x => x.StreetAddress, f => f.Address.StreetAddress())
            .RuleFor(x => x.CityPrefix, f => f.Address.CityPrefix())
            .RuleFor(x => x.CitySuffix, f => f.Address.CitySuffix())
            .RuleFor(x => x.StreetName, f => f.Address.StreetName())
            .RuleFor(x => x.BuildingNumber, f => f.Address.BuildingNumber())
            .RuleFor(x => x.StreetSuffix, f => f.Address.StreetSuffix())
            .RuleFor(x => x.SecondaryAddress, f => f.Address.SecondaryAddress())
            .RuleFor(x => x.County, f => f.Address.County())
            .RuleFor(x => x.Country, f => f.Address.Country())
            .RuleFor(x => x.FullAddress, f => f.Address.FullAddress())
            .RuleFor(x => x.CountryCode, f => f.Address.CountryCode())
            .RuleFor(x => x.State, f => f.Address.State())
            .RuleFor(x => x.StateAbbr, f => f.Address.StateAbbr())
            .RuleFor(x => x.Latitude, f => f.Address.Latitude())
            .RuleFor(x => x.Longitude, f => f.Address.Longitude())
            .RuleFor(x => x.Direction, f => f.Address.Direction())
            .RuleFor(x => x.CardinalDirection, f => f.Address.CardinalDirection())
            .RuleFor(x => x.OrdinalDirection, f => f.Address.OrdinalDirection());
    }
}

public class AddressModel
{
    public string ZipCode { get; set; }
    public string City { get; set; }
    public string StreetAddress { get; set; }
    public string CityPrefix { get; set; }
    public string CitySuffix { get; set; }
    public string StreetName { get; set; }
    public string BuildingNumber { get; set; }
    public string StreetSuffix { get; set; }
    public string SecondaryAddress { get; set; }
    public string County { get; set; }
    public string Country { get; set; }
    public string FullAddress { get; set; }
    public string CountryCode { get; set; }
    public string State { get; set; }
    public string StateAbbr { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Direction { get; set; }
    public string CardinalDirection { get; set; }
    public string OrdinalDirection { get; set; }
}
