using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Miro.API;
using System;
using System.Threading.Tasks;

namespace my_api.Controllers;

public class RedirectController : Controller
{
    IConfiguration _configuration;

    IHttpContextAccessor _accessor;

    public RedirectController(IConfiguration configuration,
        IHttpContextAccessor accessor)
    {
        _configuration = configuration;
        _accessor = accessor;
    }

    public async Task<ActionResult> Index()
    {
        try
        {
            var authorizationCode = HttpContext.Request.Query["code"].ToString();
            if (!string.IsNullOrEmpty(authorizationCode))
            {
                var miroAPI = new MiroAPI(_configuration);
                await miroAPI.OAuthToken(authorizationCode);
            }

            var clientId = _configuration["Miro:ClientId"];
            var teamId = MiroAPI.TeamId;
            var redirectUrl = _configuration["Miro:RedirectUrl"] +
                $"?client_id={clientId}" +
                $"&team_id={teamId}";

            return Redirect(redirectUrl);
        }
        catch (Exception exception)
        {
            ViewBag.Exception = exception;

            return View();
        }
    }

    // Miro calls /authorize autimatically after authentication Web SDK.
    // This method is only for testing purposes.
    public RedirectResult Authorize()
    {
        var redirectUri = _configuration["Miro:RedirectUri"];
        var clientId = _configuration["Miro:ClientId"];
        var url = "https://miro.com/oauth/authorize?" +
            "response_type=code" +
            $"&client_id={clientId}" +
            $"&redirect_uri={redirectUri}";

        return Redirect(url);
    }

    // This method is only for testing purposes.
    public ActionResult Status()
    {
        ViewBag.AccessToken = MiroAPI.AccessToken;
        ViewBag.RefreshToken = MiroAPI.RefreshToken;
        ViewBag.ExpireDateTime = MiroAPI.ExpireDateTime;
        ViewBag.TeamId = MiroAPI.TeamId;

        return View();
    }
}
