namespace WebApiWithMessageQueue.Extensions;

internal static class ApiEndpoints
{
    public static void AddApiEndpoint(this WebApplication app) 
    {
        app.MapPost("send-payment-request/{buyerName}", () =>
        {

        });
    
    }
}
