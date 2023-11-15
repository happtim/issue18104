using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.AspNetCore.Components.ExceptionHandling;
using Volo.Abp.AspNetCore.Components.Messages;

namespace issue18104.Blazor.Pages;

public partial class Index
{
    protected async Task ClickAsync()
    {
        try
        {
            throw new UserFriendlyException("Test");
        }
        catch (Exception ex)
        {
            await HandleErrorAsync(ex);
            await Message.Error(ex.Message + "1");
            await Message.Error(ex.Message + "2");
            //Logger.LogException(ex,LogLevel.Error);
        }
    }
}
