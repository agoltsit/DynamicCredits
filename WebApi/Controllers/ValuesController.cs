namespace WebApi.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;
    using log4net;

    public class ValuesController : ApiController
    {
        private static readonly ILog Log = LogManager.GetLogger(nameof(ValuesController));

        // GET: api/Values
        public IEnumerable<string> Get()
        {
            Log.Info(nameof(Get));

            return new[] {"value1", "value2"};
        }

        // GET: api/Values/5
        public string Get(int id)
        {
            Log.Info(nameof(Get));

            return "value";
        }

        // POST: api/Values
        public void Post([FromBody] string value)
        {
            Log.Info(nameof(Post));
        }

        // PUT: api/Values/5
        public void Put(int id, [FromBody] string value)
        {
            Log.Info(nameof(Put));
        }

        // DELETE: api/Values/5
        public void Delete(int id)
        {
            Log.Info(nameof(Delete));
        }
    }
}