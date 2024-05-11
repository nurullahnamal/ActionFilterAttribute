namespace ActionFilterAttribute.WebApi.Exceptions
{
    public class MissingTenantNameException : Exception
    {

        public MissingTenantNameException() : base(message: "Tenant must be privided via header")
        {

        }
    }
}
