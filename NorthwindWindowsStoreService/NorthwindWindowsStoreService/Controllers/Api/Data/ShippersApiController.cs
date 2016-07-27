
namespace NorthwindWindowsStoreService.Controllers.Api.Data
{
    using NorthwindWindowsStore.Service;
    using System.Web.Http;

    [RoutePrefix("Shippers")]
    public class ShippersApiController : BaseApiController
    {
        [Route("GetAll")]
        public IHttpActionResult GetAllShippers()
        {
            var service = new ShipperService(GetExecutingPath);
            return Ok(service.GetAll());
        }
    }
}