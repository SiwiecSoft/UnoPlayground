using UnoPlayground.Services;

namespace UnoPlayground.Presentation;

public partial record GeneralModel
{
    public BogusData Bogus { get; init; }
    public object RoutePaths { get; init; }
    public List<string> RoutePathsList { get; init; }

    public GeneralModel(DataRepository repository)
    {
        Bogus = repository.Bogus;
        RoutePaths = repository.RoutePaths;
        RoutePathsList = repository.RoutePathsList;
    }
}
