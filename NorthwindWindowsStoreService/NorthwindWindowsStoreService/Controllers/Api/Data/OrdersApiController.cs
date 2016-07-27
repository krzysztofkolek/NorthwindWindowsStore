
namespace NorthwindWindowsStoreService.Controllers.Api.Data
{
    using NorthwindWindowsStore.Service;
    using System.Web.Http;

    [RoutePrefix("Orders")]
    public class OrdersApiController : BaseApiController
    {
        [Route("GetAll")]
        public IHttpActionResult GetAllOrders()
        {
            var service = new OrderService(GetExecutingPath);
            return Ok(service.GetAll());
        }
    }
}