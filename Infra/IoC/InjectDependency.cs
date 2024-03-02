using Domain.Interface.Transaction;
using Domain.Service;
using Microsoft.Extensions.DependencyInjection;
namespace Infra.IoC
{
    public static partial class InjectDependency
    {
        public static IServiceCollection AddServicesIoC(this IServiceCollection services)
        {
            services.AddScoped<ITransactionService, TransactionService>();
            return services;
        }
    }
}
