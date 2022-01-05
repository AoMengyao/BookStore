using BookStore.BasicProject.Application.Contracts;
using BookStore.BasicProject.Application.Contracts.Users;
using BookStore.BasicProject.Application.Users;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace BookStore.BasicProject.Application
{
    [DependsOn(typeof(BasicProjectApplicationContractsModule))]
    public class BasicProjectApplicationModule: AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddTransient<IUserAppService, UserAppService>();
        }
    }
}