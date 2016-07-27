namespace NorthwindWindowsStoreService.Controllers.Api.Data
{
    using NorthwindWindowsStore.Service;
    using System.Web.Http;

    [RoutePrefix("Customer")]
    public class CustomerApiController : BaseApiController
    {
        [Route("GetAll")]
        public IHttpActionResult GetAllCustomers()
        {
            var service = new CustomerService(GetExecutingPath);
            return Ok(service.GetAll());
        }
    }
}