using AeFinder.Kubernetes;
using AeFinder.Kubernetes.Manager;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.EventBus.RabbitMq;
using Volo.Abp.Modularity;

namespace AeFinder.BackgroundWorker;

[DependsOn(typeof(AeFinderKubernetesModule),
    typeof(AbpEventBusRabbitMqModule),
    typeof(AeFinderApplicationModule))]
public class AeFinderBackGroundModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options => { options.AddMaps<AeFinderBackGroundModule>(); });
        context.Services.AddTransient<IKubernetesAppManager, KubernetesAppManager>();
    }
}