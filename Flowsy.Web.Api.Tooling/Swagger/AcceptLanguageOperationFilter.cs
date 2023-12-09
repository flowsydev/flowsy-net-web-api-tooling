using Microsoft.Net.Http.Headers;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Flowsy.Web.Api.Tooling.Swagger;

/// <summary>
/// Adds the Accept-Language header to Swagger requests.
/// </summary>
public sealed class AcceptLanguageOperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        operation.Parameters.Add(new OpenApiParameter
        {
            In = ParameterLocation.Header,
            Name = HeaderNames.AcceptLanguage,
            Required = false
        });
    }
}