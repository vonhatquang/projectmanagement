using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Helper
{
    public class ApiClient
    {

        private ApiSetting _apiSetting;
        private HttpClient _client;
        private string _apiController;
        private string _apiAction;
        public ApiClient(ApiSetting apiSetting)
        {
            this._apiSetting = apiSetting;
        }

        public void InitializeClient(string apiCaller)
        {
            string[] stringSeparators = new string[] { "_" };
            this._apiController = apiCaller.Split(stringSeparators, StringSplitOptions.None)[0];
            this._apiAction = apiCaller.Split(stringSeparators, StringSplitOptions.None)[1];
            this._client = new HttpClient();
            //Passing service base url    
            this._client.BaseAddress = new Uri(this._apiSetting.ApiUrl.ToString());

            this._client.DefaultRequestHeaders.Clear();
            //Define request data format    
            this._client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private string MakeApiUri(List<ApiParameter> parameters = null)
        {
            ApiController webApiController = this._apiSetting.ApiControllers.Find(x => x.Name == this._apiController);
            ApiAction webApiAction = webApiController.ApiActions.Find(x => x.Name == this._apiAction);
            string returnValue = "";
            returnValue += this._apiSetting.ApiPrefix;
            returnValue += "/" + webApiController.Name;
            returnValue += "/" + webApiAction.Name;
            if (parameters != null)
            {
                string parameterValue = "";
                if (webApiAction.IsCustom)
                {
                    for (int i = 0; i < parameters.Count; i++)
                    {
                        if ("".Equals(parameterValue))
                        {
                            parameterValue += "?" + parameters[i].Name + "=" + parameters[i].Value;
                        }
                        else
                        {
                            parameterValue += "&" + parameters[i].Name + "=" + parameters[i].Value;
                        }
                    }
                    returnValue += parameterValue;
                }
                else
                {
                    returnValue += "/" + parameters[0].Value;
                }

            }
            return returnValue;
        }

        public async Task<List<T>> List<T>(List<ApiParameter> parameters = null)
        {
            HttpResponseMessage res = await this._client.GetAsync(MakeApiUri(parameters));

            //Checking the response is successful or not which is sent using HttpClient    
            if (res.IsSuccessStatusCode)
            {
                //Deserializing the response recieved from web api and storing into the Employee list    
                return JsonConvert.DeserializeObject<List<T>>(res.Content.ReadAsStringAsync().Result);                
            }
            return default(List<T>);
        }

        public async Task<T> Get<T>(List<ApiParameter> parameters = null)
        {
            HttpResponseMessage res = await this._client.GetAsync(MakeApiUri(parameters));
            //Checking the response is successful or not which is sent using HttpClient    
            if (res.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<T>(res.Content.ReadAsStringAsync().Result);
            }
            return default(T);
        }

        public async Task<int> Post<T>(T postItem)
        {
            string stringData = JsonConvert.SerializeObject(postItem);
            var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage res = await this._client.PostAsync(MakeApiUri(), contentData);
            //var result = res.Content.ReadAsStringAsync().Result;
            //res.EnsureSuccessStatusCode();
            if (res.IsSuccessStatusCode){
                return int.Parse(res.Content.ReadAsStringAsync().Result.ToString());
            }
            //var returnVal = res.Content.ReadAsStringAsync().Result;
            return -1;//JsonConvert.DeserializeObject<T>(returnVal);
        }

        public async Task<int> Put<T>(List<ApiParameter> parameters, T putItem)
        {
            string stringData = JsonConvert.SerializeObject(putItem);
            var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage res = await this._client.PutAsync(MakeApiUri(parameters), contentData);
            //var result = res.Content.ReadAsStringAsync().Result;
            //res.EnsureSuccessStatusCode();
            if (res.IsSuccessStatusCode){
                return int.Parse(res.Content.ReadAsStringAsync().Result.ToString());
            }
            //var returnVal = res.Content.ReadAsStringAsync().Result;
            return -1;//JsonConvert.DeserializeObject<T>(returnVal);
        }

        public async Task<int> Delete(List<ApiParameter> parameters)
        {
            HttpResponseMessage res = await this._client.DeleteAsync(MakeApiUri(parameters));
            //res.EnsureSuccessStatusCode();
            if (res.IsSuccessStatusCode){
                return int.Parse(res.Content.ReadAsStringAsync().Result.ToString());
            }
            //var returnVal = res.Content.ReadAsStringAsync().Result;
            return -1;//returnVal.ToString();
        }
    }
}
