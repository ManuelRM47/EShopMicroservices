using System.Reflection;

namespace Basket.API;

public class BasketCarterAssembly : DependencyContextAssemblyCatalog
{
    public override IReadOnlyCollection<Assembly> GetAssemblies()
        => [typeof(Program).Assembly];
}
