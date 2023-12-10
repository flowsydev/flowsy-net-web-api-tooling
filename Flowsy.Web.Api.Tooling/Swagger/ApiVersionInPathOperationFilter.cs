using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Flowsy.Web.Api.Tooling.Swagger;

public sealed class ApiVersionInPathOperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        operation.Parameters.Add(new OpenApiParameter
        {
            In = ParameterLocation.Path,
            Name = "apiVersion",
            Required = false
        });
    }
}