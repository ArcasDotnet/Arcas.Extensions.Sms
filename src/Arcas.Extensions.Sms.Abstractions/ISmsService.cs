using System.Threading;
using System.Threading.Tasks;

namespace Arcas.Extensions.Sms
{
    /// <summary>
    /// 短信服务接口
    /// </summary>
    public interface ISmsService
    {
        /// <summary>
        /// 发送短信
        /// </summary>
        /// <param name="phone">手机号码</param>
        /// <param name="content">短信内容</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<(bool success, string message)> SendAsync(long phone, string content, CancellationToken cancellationToken = default(CancellationToken));
    }
}
