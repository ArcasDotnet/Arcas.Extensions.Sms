using System;
using System.Threading;
using System.Threading.Tasks;

namespace Arcas.Extensions.Sms.Aliyun
{
    public class AliyunSmsService : ISmsService
    {
        public Task<(bool success, string message)> SendAsync(long phone, string content, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
    }
}
