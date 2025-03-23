using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace UnoPlayground.Extensions;

public static class HostBuilderExtensions
{
    public static IHostBuilder UsePlaygroundNavigation(this IHostBuilder builder)
    {
        builder.UseNavigation(ReactiveViewModelMappings.ViewModelMappings, RegisterRoutes);

        return builder;
    }

    [RequiresUnreferencedCode("")]
    private static void RegisterRoutes(IViewRegistry views, IRouteRegistry routes)
    {
        views.Register(
            new ViewMap(ViewModel: typeof(ShellModel))
        );

        RegisterModels(views);

        routes.Register(
            new RouteMap("", View: views.FindByViewModel<ShellModel>(),
                Nested: RegisterViews(views)
            )
        );
    }

    /// <summary>
    /// <b>Replaces such code with reflection</b> <br></br>
    /// views.Register(  <br></br>
    ///     new ViewMap&lt;MainPage, GeneralModel&gt;(), <br></br>
    ///     new ViewMap&lt;SecondPage, GeneralModel&gt;(), <br></br>
    ///     ...
    /// </summary>
    /// <param name="views"></param>
    [RequiresUnreferencedCode("")]
    private static void RegisterModels(IViewRegistry views)
    {
        IEnumerable<Type> pageTypes = GetPageTypes();

        foreach (var pageType in pageTypes)
        {
            var instance = Activator.CreateInstance(
                typeof(ViewMap<,>).MakeGenericType(pageType, typeof(GeneralModel)),
                [null, null, null]
            );

            if (instance is ViewMap viewMap)
            {
                views.Register(viewMap);
            }
        }
    }

    [RequiresUnreferencedCode("")]
    private static IEnumerable<Type> GetPageTypes()
    {
        return Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(Page)));
    }

    /// <summary>
    /// <b>Replaces such code with reflection</b> <br></br>
    ///    new ("Main", View: views.FindByViewModel&lt;MainModel&gt;(), IsDefault:true), <br></br>
    ///    new ("Second", View: views.FindByViewModel&lt;SecondModel&gt;()), <br></br>
    ///    ... <br></br>
    /// </summary>
    /// <param name="views"></param>
    /// <returns></returns>
    [RequiresUnreferencedCode("")]
    private static RouteMap[] RegisterViews(IViewRegistry views)
    {
        var methodInfo = typeof(ViewRegistryExtensions).GetMethod(
            "FindByView",
            BindingFlags.Static | BindingFlags.Public,
            null,
            new[] { typeof(IViewRegistry) },
            null
        );

        var routeMaps = GetPageTypes()
            .Where(type => !type.Name.Contains("Main"))
            .Select(type =>
            {
                var genericMethod = methodInfo.MakeGenericMethod(type);
                var foundView = (ViewMap)genericMethod.Invoke(null, new object?[] { views });

                return new RouteMap(
                    Path: type.Name,
                    View: foundView
                );
            })
            .ToArray();

        return [.. routeMaps, new("Main", View: views.FindByView<MainPage>(), IsDefault: true)];
    }
}
