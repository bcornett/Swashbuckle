// Type: System.Web.Http.Routing.BoundRouteTemplate
// Assembly: System.Web.Http, Version=5.2.2.0, Culture=neutral, PublicKeyToken=null
// MVID: 41E7509A-D984-42AB-9810-05395DB3F043
// Assembly location: C:\Users\bcornett\Downloads\aspnetwebstack-5fa60ca38b5837cc843b5d4552113f9a0235c3bf\bin\Debug\System.Web.Http.dll

using System.Web.Http.Routing;

namespace Swashbuckle.ApiExplorer
{
    /// <summary>
    /// Represents a URI generated from a <see cref="T:Swashbuckle.ApiExplorer.HttpParsedRoute"/>.
    /// 
    /// </summary>
    internal class BoundRouteTemplate
    {
        public string BoundTemplate { get; set; }

        public HttpRouteValueDictionary Values { get; set; }
    }
}
