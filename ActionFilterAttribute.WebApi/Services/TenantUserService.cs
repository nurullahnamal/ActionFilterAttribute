using ActionFilterAttribute.WebApi.Models;

namespace ActionFilterAttribute.WebApi.Services
{
    public class TenantUserService
    {
        private readonly TenantModel tenantModel;

        public TenantUserService(TenantModel tenantModel)
        {
            this.tenantModel = tenantModel;
        }



        public IEnumerable<User> GetAllUsers()
        {
            return new List<User>()
            {
                new User() { Id = 1, EmailAddress = $"nurullahnamal91@gmail.com {tenantModel.Name}" }
            };
        }
    }
}

