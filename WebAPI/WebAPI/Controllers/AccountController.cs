using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Profgyan.Data;
using Profgyan.Model;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;

namespace ProfGyan.Controllers
{
    public class AccountController : ApiController
    {
        // POST api/Account/Register
        [AllowAnonymous]
        [Route("api/User/Register")]
        [HttpPost]
        public async Task<IdentityResult> Register(RegisterBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return new IdentityResult("Registraion Data not valid");
                //return BadRequest(ModelState);
            }
            var userStore = new UserStore<ProfGyanUser>(new ProfGyanDBContext());
            var manager = new UserManager<ProfGyanUser>(userStore);
            var user = new ProfGyanUser() { UserName = model.UserName, Email = model.Email };
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;

            IdentityResult result = await manager.CreateAsync(user, model.Password);
            return result;

        }

        [HttpGet]
        [Route("api/GetUserClaims")]
        [Authorize]
        //Only for testing the Auth and auth feature
        public RegisterBindingModel GetUserClaims()
        {
            var identityClaims = (ClaimsIdentity)User.Identity;
            IEnumerable<Claim> claims = identityClaims.Claims;
            RegisterBindingModel model = new RegisterBindingModel()
            {
                UserName = identityClaims.FindFirst("Username").Value,
                Email = identityClaims.FindFirst("Email").Value,
                FirstName = identityClaims.FindFirst("FirstName").Value,
                LastName = identityClaims.FindFirst("LastName").Value,
                LoggedOn = identityClaims.FindFirst("LoggedOn").Value
            };
            return model;
        }

    }
}
