namespace UnoPlayground.Services;

public class DataRepository()
{
    public BogusData Bogus { get; } = new BogusData();
    public object RoutePaths { get; } = DynamicPageRepositoryGenerator.Generate();
}
