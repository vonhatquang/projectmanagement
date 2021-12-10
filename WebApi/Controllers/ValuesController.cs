using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient; 
using System.Data; 
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Helper;

namespace WebApi.Controllers
{
    /* [Route("api/[controller]/[action]")]*/
    //[Route("api/[controller]/[action]")]
    public class ValuesController : BaseController
    {        
        public ValuesController(IOptions<ConnectionInfo> connectionInfo, IDataAccessHelper dataAccessHelper):base(connectionInfo,dataAccessHelper){}
        /*public ConnectionInfo _ConnectionInfo;

        public ValuesController(IOptions<ConnectionInfo> connectionInfo){
            _ConnectionInfo = connectionInfo.Value;
        }*/
        /*[HttpGet]
        public string GetDTO(string a)
        {
            return a;
        }

        [HttpGet]
        public IEnumerable<string> ListDTO(string a, string b){
            return new string[] { a, b };
        }
        

        // POST api/values
        [HttpPost]
        public string Post([FromBody]string a)
        {
            return "Post Value : " + a;
        }

        // PUT api/values/5
        //[HttpPut("{id}")]
        [HttpPut]
        public string Put(string a)
        {
            return "Put Value:"+ a;
        }

        // DELETE api/values/5
        //[HttpDelete("{id}")]
        [HttpDelete]
        public string Delete(string a)
        {
            return "Delete Value:" + a;
        }
        */

        // GET api/values/ListCustom
        [HttpGet]
        public override DataTable ListCustom()
        {
            string connectionString = base._ConnectionInfo.Connections.Find(item => item.ConnectionName == "AWBMConnection").ConnectionString;
            //string storeProcedureName = "SelectAllUser";            
            string storeProcedureName = base.GetSQLContent("SelectUser");            
            return base._DataAccessHelper.List(connectionString,storeProcedureName);
        }

        // GET api/values/GetCustom?id=5
        [HttpGet]
        public override DataTable GetCustom(string id)
        {
            string connectionString = base._ConnectionInfo.Connections.Find(item => item.ConnectionName == "AWBMConnection").ConnectionString;
            string storeProcedureName = base.GetSQLContent("SelectUser");         
            return base._DataAccessHelper.Get(connectionString,storeProcedureName,base.CreateSQLParameter(nameof(id),id));
        }

        // GET api/values/List
        [HttpGet]
        public override DataTable List()
        {
            string connectionString = base._ConnectionInfo.Connections.Find(item => item.ConnectionName == "AWBMConnection").ConnectionString;
            string storeProcedureName = base.GetSQLContent("SelectUser");         
            return base._DataAccessHelper.List(connectionString,storeProcedureName);
        }

        // GET api/values/Get/5
        [HttpGet("{id}")]
        public override DataTable Get(string id)
        {
            string connectionString = base._ConnectionInfo.Connections.Find(item => item.ConnectionName == "AWBMConnection").ConnectionString;
            string storeProcedureName = base.GetSQLContent("SelectUser");         
            return base._DataAccessHelper.Get(connectionString,storeProcedureName,base.CreateSQLParameter(nameof(id),id));
        }

        // POST api/values/Post
        [HttpPost]
        public override int Post([FromBody]JObject postItem)
        {
            //PostItem postItem0 = new PostItem(){id=postItem.id}; 
            
            //return postItem.ToString();
            
            DataRow dr = base.ConvertPostPutItem(postItem);
            string returnPost = "";
            returnPost = dr["id"].ToString();
            return int.Parse(returnPost);
            /*var item = JsonConvert.DeserializeObject<PostItem>(postItem);
            return int.Parse(JsonConvert.DeserializeObject<PostItem>(postItem).value);*/
            //DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(postItem);
            /*DataTable dt = (DataTable)JsonConvert.DeserializeObject(postItem, (typeof(DataTable)));
            string returnPost = "";
            foreach (DataRow row in dt.Rows)
            {
                returnPost = row["id"].ToString();
            }*/
            //return postItem;//dt;//.Rows.Count;//int.Parse(returnPost);
        }

        // PUT api/values/Put/5
        [HttpPut("{id}")]
        public override int Put(string id, [FromBody]JObject putItem)
        {
            /*PostItem postItem0 = new PostItem(){value="Put"}; 
            postItem.value = postItem.value + "-" + postItem0.value;
            return postItem;
            var item = JsonConvert.DeserializeObject<PostItem>(putItem);
            return int.Parse(JsonConvert.DeserializeObject<PostItem>(putItem).value);*/
            
            DataRow dr = base.ConvertPostPutItem(putItem);
            string returnPut = "";
            returnPut = dr["id"].ToString();
            return int.Parse(returnPut);
        }

        // DELETE api/values/Delete/5
        [HttpDelete("{id}")]
        public override int Delete(string id)
        {
            /*PostItem postItem0 = new PostItem(){value="Delete"}; 
            return "Delete Value : " + id.ToString() + " - " + postItem0.value;*/
            return int.Parse(id);
        }
    }
}
