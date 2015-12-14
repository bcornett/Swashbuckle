using Swashbuckle.ApiExplorer;

namespace Swashbuckle.Swagger
{
    public interface IOperationFilter
    {
        void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription);
    }
}
