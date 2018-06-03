using Microsoft.AspNetCore.Antiforgery;
using SardineBlog.Controllers;

namespace SardineBlog.Web.Host.Controllers
{
    public class AntiForgeryController : SardineBlogControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
