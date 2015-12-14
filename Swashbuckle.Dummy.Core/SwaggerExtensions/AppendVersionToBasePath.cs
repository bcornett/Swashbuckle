using System.Linq;
using Swashbuckle.Swagger;

namespace Swashbuckle.Dummy.SwaggerExtensions
{
    public class AppendVersionToBasePath : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, SchemaRegistry schemaRegistry, ApiExplorer.ApiExplorer apiExplorer)
        {
            swaggerDoc.basePath = "/" + swaggerDoc.info.version;

            swaggerDoc.paths = swaggerDoc.paths.ToDictionary(
                entry => entry.Key.Replace("/{apiVersion}", ""),
                entry => RemoveVersionParamsFrom(entry.Value));
        }

        private PathItem RemoveVersionParamsFrom(PathItem pathItem)
        {
            RemoveVersionParamFrom(pathItem.get);
            RemoveVersionParamFrom(pathItem.put);
            RemoveVersionParamFrom(pathItem.post);
            RemoveVersionParamFrom(pathItem.delete);
            RemoveVersionParamFrom(pathItem.options);
            RemoveVersionParamFrom(pathItem.head);
            RemoveVersionParamFrom(pathItem.patch);
            return pathItem;
        }

        private void RemoveVersionParamFrom(Operation operation)
        {
            if (operation == null) return;

            var versionParam = operation.parameters.SingleOrDefault(param => param.name == "apiVersion");
            if (versionParam != null) operation.parameters.Remove(versionParam);
        }
    }
}
