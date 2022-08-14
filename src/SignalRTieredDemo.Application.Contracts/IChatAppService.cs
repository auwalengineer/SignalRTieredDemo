using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace SignalRTieredDemo
{
    public interface IChatAppService : IApplicationService
    {
        Task SendMessageAsync(SendMessageInput input);
    }
}
