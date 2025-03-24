using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace UnoPlayground.Services;

public class DataRepository
{
    public BogusData Bogus { get; } = new BogusData();
    public object RoutePaths { get; init; }
    public List<string> RoutePathsList { get; init; }

    public DataRepository()
    {
        var pageNames = GetPageNames();

        RoutePathsList = pageNames.Where(name => !name.Contains("Main")).ToList();
        RoutePaths  = DynamicPageRepositoryGenerator.Generate(pageNames);
    }

    [RequiresUnreferencedCode("")]
    private static List<string> GetPageNames()
    {
        return Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(Page)))
            .Select(t => t.Name)
            .ToList();
    }
}
