using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Arcas.Extensions.Sms.Aliyun
{
    public class AliyunSmsService : IShortMessageService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<AliyunSmsService> _logger;
        private readonly AliyunSmsConfiguration _config;

        public AliyunSmsService(
            AliyunSmsConfiguration configuration,
            HttpClient httpClient,
            ILogger<AliyunSmsService> logger)
        {
            _config = configuration;
            _logger = logger;
            _httpClient = httpClient;
        }

        public Task<(bool success, string message)> SendSmsAsync(long phone, string content, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
    }
}
