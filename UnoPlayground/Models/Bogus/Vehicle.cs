using Bogus;

namespace UnoPlayground.Models.Bogus;

public class Vehicle
{
    public Faker<VehicleModel> Faker { get; init; }

    public Vehicle()
    {
        Faker = new Faker<VehicleModel>()
            .RuleFor(x => x.Vin, f => f.Vehicle.Vin())
            .RuleFor(x => x.Manufacturer, f => f.Vehicle.Manufacturer())
            .RuleFor(x => x.Model, f => f.Vehicle.Model())
            .RuleFor(x => x.Type, f => f.Vehicle.Type())
            .RuleFor(x => x.Fuel, f => f.Vehicle.Fuel());
    }
}

public class VehicleModel
{
    public string Vin { get; set; }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public string Type { get; set; }
    public string Fuel { get; set; }
}
