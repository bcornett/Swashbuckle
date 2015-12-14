// Type: System.Web.Mvc.Routing.ParsedRoute
// Assembly: System.Web.Mvc, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: CC73190B-AB9D-435C-8315-10FF295C572A
// Assembly location: D:\Projects\packages\Microsoft.AspNet.Mvc.5.2.3\lib\net45\System.Web.Mvc.dll

using System.Collections.Generic;

namespace Swashbuckle.ApiExplorer
{
    internal class ParsedRoute
    {
        public IList<PathSegment> PathSegments { get; private set; }

        public ParsedRoute(IList<PathSegment> pathSegments)
        {
            this.PathSegments = pathSegments;
        }
    }
}
