using Identity.Domain;

namespace Identity.Service.EventHandlers.Responses
{
    public class IdentityAccess
    {
        public bool Succeeded { get; set; }
        public string AccessToken { get; set; }
        public string UserName { get; set; }
        public List<Role> Roles { get; set; } = new List<Role>();
        public string errorMessage { get; set; }
    }
    public class Role
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
