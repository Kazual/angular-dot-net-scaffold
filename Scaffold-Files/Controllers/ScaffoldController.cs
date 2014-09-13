using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlatformAdminSite.Controllers
{
    [Authorize]
    public class ScaffoldController : Controller
    {

        #region View Controllers

        // GET: /Scaffold/
        public ActionResult Index()
        {
            return View();
        }


        // Used for Detail variation
        // GET: /Scaffold/{id}
        [Route("Scaffold/{id}")]
        public ActionResult Details()
        {
            return View("Index"); //<---Redirect to main index, angular will take ouver routing
        }

        #endregion


        #region JSON Services

        #region Initializaton

        [Route("Scaffold/Json/Get")]
        [HttpGet]
        public JsonNetResult GetScaffold()
        {
            /*
            var accountManagementServiceClient = new AccountManagementService.AccountManagementServiceClient();
            accountManagementServiceClient.Open();

            var accounts = accountManagementServiceClient.GetAccounts(page, amount, sortBy + " " + direction);
            accountManagementServiceClient.Close();

            JsonNetResult jsonNetResult = new JsonNetResult();
            jsonNetResult.Formatting = Newtonsoft.Json.Formatting.Indented;
            jsonNetResult.Data = accounts;

            return jsonNetResult;
            */

            var results = new string[] {"one", "two", "three", "four"};

            JsonNetResult jsonNetResult = new JsonNetResult();
            jsonNetResult.Formatting = Newtonsoft.Json.Formatting.Indented;
            jsonNetResult.Data = results;

            return jsonNetResult;

        }

        #endregion


        #region Details


        [Route("Scaffold/Json/Details/{id}")]
        public JsonNetResult Detail(string id)
        {
            /*
            var accountManagementServiceClient = new AccountManagementService.AccountManagementServiceClient();
            accountManagementServiceClient.Open();

            var account = accountManagementServiceClient.GetAccount(name);
            accountManagementServiceClient.Close();

            JsonNetResult jsonNetResult = new JsonNetResult();
            jsonNetResult.Formatting = Newtonsoft.Json.Formatting.Indented;
            jsonNetResult.Data = account;

            return jsonNetResult;
            */

            var results = new string[] {"details 1", "details 2"};

            JsonNetResult jsonNetResult = new JsonNetResult();
            jsonNetResult.Formatting = Newtonsoft.Json.Formatting.Indented;
            jsonNetResult.Data = results;

            return jsonNetResult;
        }

        #endregion


        #region Updates

        [Route("Accounts/Json/UpdateSomething")]
        [HttpPost]
        public JsonNetResult UpdateSomething(string id, string name)
        {
            /*
            var accountManagementServiceClient = new AccountManagementService.AccountManagementServiceClient();
            accountManagementServiceClient.Open();

            var response = accountManagementServiceClient.UpdateAccountName(accountId, newName,
                AuthenticationCookieManager.GetAuthenticationCookie().ID,
                PlatformAdminSite.AccountManagementService.RequesterType.PlatformUser);
            accountManagementServiceClient.Close();

            JsonNetResult jsonNetResult = new JsonNetResult();
            jsonNetResult.Formatting = Newtonsoft.Json.Formatting.Indented;
            jsonNetResult.Data = response;

            return jsonNetResult;
             */

            JsonNetResult jsonNetResult = new JsonNetResult();
            jsonNetResult.Formatting = Newtonsoft.Json.Formatting.Indented;
            jsonNetResult.Data = "DataAccessResponseType";

            return jsonNetResult;
        }

        #endregion


        #endregion



    }
}