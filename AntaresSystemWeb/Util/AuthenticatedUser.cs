using System.Security.Claims;

namespace AntaresSystemWeb.Util
{
    public class AuthenticatedUser
    {
        public AuthenticatedUser(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        private readonly IHttpContextAccessor _accessor;
        public string Login => _accessor.HttpContext.User.Identity.Name;
        public Guid Id => Guid.Parse(GetClaimsIdentity().FirstOrDefault(a => a.Type == ClaimTypes.NameIdentifier)?.Value);

        public IEnumerable<Claim> GetClaimsIdentity()
        {
            var result = _accessor.HttpContext.User.Claims;
            return result;
        }
    }
}
