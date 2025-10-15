using System.Reflection;

namespace Catalog.API;

public class CatalogCarterAssembly : DependencyContextAssemblyCatalog
{
    public override IReadOnlyCollection<Assembly> GetAssemblies()
        => [typeof(Program).Assembly];
}
