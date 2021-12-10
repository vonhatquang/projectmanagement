using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;  
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using WebApp.Models;
//using WebApp.Helpers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Helper;
using Newtonsoft.Json;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApiSetting _apiSetting;
        private readonly IStringHelper _stringHelper;
        public AccountController(IOptions<ApiSetting> apiSetting, IStringHelper stringHelper)
        {
            this._apiSetting = apiSetting.Value;
            this._stringHelper = stringHelper;
        }
        /*public IActionResult Index(string ReturnUrl)
        {
            //ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }*/
        public IActionResult Login(string ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }

        [HttpPost]  
        [ValidateAntiForgeryToken]  
        public async Task<IActionResult> UserLogin(LoginUserModel model)  
        {    
            string userName = model.UserName;
            
            ApiClient client = new ApiClient(this._apiSetting);            
            List<ApiParameter> parameters = new List<ApiParameter>();            
            ApiParameter parameter = new ApiParameter();
            
            PostItem item = new PostItem();
            /*
            //ListCustom
            client.InitializeClient(ApiConst.VALUES_LISTCUSTOM);
            List<PostItem> listCustom = await client.List<PostItem>();
            
            //GetCustom
            client.InitializeClient(ApiConst.VALUES_GETCUSTOM);
            parameters = new List<ApiParameter>();  
            parameters.Add(new ApiParameter(){Name="id", Value="0"});
            string getCustom = await client.Get(parameters);

            //List                       
            client.InitializeClient(ApiConst.VALUES_LIST);
            string listReturn = await client.List();

            //Get
            client.InitializeClient(ApiConst.VALUES_GET);
            parameters = new List<ApiParameter>();  
            parameters.Add(new ApiParameter(){Name="id", Value="0"});
            string getReturn = await client.Get(parameters);

            //Post
            client.InitializeClient(ApiConst.VALUES_POST);
            item = new PostItem();
            item.id = "2000";
            int post = await client.Post(item);

            //Put
            client.InitializeClient(ApiConst.VALUES_PUT);
            parameters = new List<ApiParameter>();  
            parameters.Add(new ApiParameter(){Name="id", Value="0"});
            item = new PostItem();
            item.value = "3000";
            int put = await client.Put(parameters,item);

            //Delete
            client.InitializeClient(ApiConst.VALUES_DELETE);
            parameters = new List<ApiParameter>();  
            parameters.Add(new ApiParameter(){Name="id", Value="0"});
            int delete = await client.Delete(parameters);
            */

            string newPass = this._stringHelper.EncodePassword(model.Password);

            if (ModelState.IsValid)  
            {  
                //string LoginStatus = objUser.ValidateLogin(user);  
  
                /*if (UserID.Equals("1") && Password.Equals(1))  
                { */ 
                    var claims = new List<Claim>  
                    {  
                        /*new Claim(ClaimTypes.Name, UserID)  */
                        new Claim(ClaimTypes.Name, "1")  
                    };  
                    ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");  
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);  
  
                    await HttpContext.SignInAsync(principal,new AuthenticationProperties
                    {
                        ExpiresUtc = DateTime.UtcNow.AddMinutes(20),
                        IsPersistent = false,
                        AllowRefresh = false
                    });  
                        
                    if (Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else{
                     
                        return RedirectToAction("Index", "Home", new {area=""});  
                    } 
                /*}  
                else  
                {  
                    TempData["UserLoginFailed"] = "Login Failed.Please enter correct credentials";  
                    return View();  
                }  */
            }  
            else  
                return View();  
  
        }  
        public async Task<IActionResult> UserLogout(/*string UserID, string Password*/)  
        {    
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home", new {area=""});  

        }  
    }
}
