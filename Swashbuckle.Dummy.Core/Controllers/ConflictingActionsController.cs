using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Http;

namespace Swashbuckle.Dummy.Controllers
{
    public class ConflictingActionsController : ApiController
    {
        public IEnumerable<string> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAllByKeyword(int id, [FromUri]MyObject t)
        {
            throw new NotImplementedException();
        }
    }

    public class MyObject
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}