using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Data; 
using Helper;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Collections.Generic;
namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    public abstract class BaseController : Controller
    {
        protected ConnectionInfo _ConnectionInfo;
        protected IDataAccessHelper _DataAccessHelper;

        protected DataRow ConvertPostPutItem(JObject item){
            JArray items = new JArray();
            items.Add(item);
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(items.ToString(), (typeof(DataTable)));
            return dt.Rows[0];
        }

        protected string GetSQLContent(string sqlFileName){
            string sqlContents = "";
            string sqlFilePath = @".\SQL\" + sqlFileName + ".sql";
            using (StreamReader streamReader = new StreamReader(sqlFilePath, Encoding.UTF8))
            {
                sqlContents = streamReader.ReadToEnd();
            }
            return sqlContents;
        }

        protected List<DataAccessHelperParameter> CreateSQLParameter(string parameterName, string parameterValue){
            DataAccessHelperParameter tmp = new DataAccessHelperParameter();
            tmp.Name=parameterName;//nameof(parameter);
            tmp.Value=parameterValue;
            List<DataAccessHelperParameter> parameters =  new List<DataAccessHelperParameter>();
            parameters.Add(tmp);  
            return parameters;
        }

        public BaseController(IOptions<ConnectionInfo> connectionInfo, IDataAccessHelper dataAccessHelper){
            _ConnectionInfo = connectionInfo.Value;
            _DataAccessHelper = dataAccessHelper;
        }
        
        // GET api/values/ListCustom
        [HttpGet]
        public abstract DataTable ListCustom();

         // GET api/values/List
        [HttpGet]        
        public abstract DataTable List();

        // GET api/values/GetCustom?id=5
        [HttpGet]
        public abstract DataTable GetCustom(string id);

        // GET api/values/Get/5
        [HttpGet("{id}")]
        public abstract DataTable Get(string id);

        // POST api/values/Post
        [HttpPost]
        public abstract int Post([FromBody]JObject postItem);

        // PUT api/values/Put/5
        [HttpPut("{id}")]
        public abstract int Put(string id, [FromBody]JObject putItem);

        // DELETE api/values/Delete/5
        [HttpDelete("{id}")]
        public abstract int Delete(string id);
    }
}