using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Flowsy.Web.Api.Tooling.Swagger;

/// <summary>
/// Adds the X-Version header and the apiVersion query parameter to Swagger requests.
/// </summary>
public sealed class ApiVersionInQueryOperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        operation.Parameters.Add(new OpenApiParameter
        {
            In = ParameterLocation.Query,
            Name = "apiVersion",
            Required = false
        });
    }
}