using System.Reflection;
using System.Reflection.Emit;

namespace UnoPlayground.Services;

public class DynamicPageRepositoryGenerator
{
    public static object Generate(List<string> pageNames)
    {
        var assemblyName = new AssemblyName("DynamicPagesAssembly");
        var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
        var moduleBuilder = assemblyBuilder.DefineDynamicModule(assemblyName.Name);

        var typeBuilder = moduleBuilder.DefineType(
            "DynamicPageRepository",
            TypeAttributes.Public | TypeAttributes.Class
        );

        foreach (var propertyName in pageNames)
        {
            var propBuilder = typeBuilder.DefineProperty(
                propertyName,
                PropertyAttributes.HasDefault,
                typeof(string),
                null
            );

            var getMethodBuilder = typeBuilder.DefineMethod(
                "get_" + propertyName,
                MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig,
                typeof(string),
                Type.EmptyTypes
            );

            var ilGet = getMethodBuilder.GetILGenerator();
            ilGet.Emit(OpCodes.Ldstr, propertyName);
            ilGet.Emit(OpCodes.Ret);

            propBuilder.SetGetMethod(getMethodBuilder);
        }

        var repoType = typeBuilder.CreateType();
        var repoInstance = Activator.CreateInstance(repoType);

        return repoInstance;
    }
}
