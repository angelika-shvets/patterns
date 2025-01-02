using Autofac;

namespace Patterns.Bootstrap;

public class AutoDiscoveryRegistrar : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterAssemblyTypes(
                typeof(Api.AssemblyAnchor).Assembly,
                typeof(Domain.AssemblyAnchor).Assembly
            )
            .AsImplementedInterfaces()
            .SingleInstance();
    }
}