namespace Swashbuckle.Swagger
{
    public interface IDocumentFilter
    {
        void Apply(SwaggerDocument swaggerDoc, SchemaRegistry schemaRegistry, ApiExplorer.ApiExplorer apiExplorer);
    }
}
