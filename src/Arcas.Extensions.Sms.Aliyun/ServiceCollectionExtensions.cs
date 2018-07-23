using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Net.Http;

namespace Arcas.Extensions.Sms.Aliyun
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAliyunSmsService(this IServiceCollection services, AliyunSmsConfiguration smsConfiguration)
        {
            if (smsConfiguration == null)
            {
                throw new ArgumentNullException(nameof(smsConfiguration));
            }
            services.AddSingleton(smsConfiguration);

            var registration = services.FirstOrDefault(service => service.ServiceType == typeof(HttpClient));
            if (registration == null)
            {
                services.AddSingleton<HttpClient>();
            }

            services.AddSingleton<IShortMessageService, AliyunSmsService>();

            return services;
        }
    }
}
