using Microsoft.Extensions.DependencyInjection;

namespace Arcas.Extensions.Sms.Aliyun
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAliyunSmsService(this IServiceCollection services)
        {
            services.AddSingleton<ISmsService, AliyunSmsService>();

            return services;
        }
    }
}
