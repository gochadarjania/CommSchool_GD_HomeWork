using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Week_13.MiddleWare
{
    public class MyFirstMiddleWare
    {
        private readonly RequestDelegate _next;
        public MyFirstMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, IConfiguration config)
        {
            var contollerActionDescriptor = httpContext.GetEndpoint().Metadata.GetMetadata<ControllerActionDescriptor>();

            var controllerName = contollerActionDescriptor.ControllerName;
            var actionName = contollerActionDescriptor.ActionName;

            Endpoint endpoint = httpContext.Features.Get<IEndpointFeature>()?.Endpoint;
            if (endpoint != null)
            {

                var info = config.GetSection("Information").GetChildren().FirstOrDefault(x => x.Key == actionName);
                
                if (info != null && !bool.Parse(info.Value))
                {
                    httpContext.SetEndpoint(new Endpoint((context) =>
                    {
                    context.Response.StatusCode = StatusCodes.Status404NotFound;
                    context.Response.WriteAsync(string.Join("\n", "Booking is impossible!"));
                        return Task.CompletedTask;
                    },
                    EndpointMetadataCollection.Empty, "Resurse not found"));
                }
            }

            await _next(httpContext);
        
        }
    }
}
