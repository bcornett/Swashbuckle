using Swashbuckle.Swagger;

namespace Swashbuckle.Dummy.SwaggerExtensions
{
    public class ApplyDocumentVendorExtensions : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, SchemaRegistry schemaRegistry, ApiExplorer.ApiExplorer apiExplorer)
        {
            swaggerDoc.vendorExtensions.Add("x-document", "foo");
        }
    }
}
