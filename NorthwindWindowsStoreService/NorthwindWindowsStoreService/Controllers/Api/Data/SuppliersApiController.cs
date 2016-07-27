
namespace NorthwindWindowsStoreService.Controllers.Api.Data
{
    using NorthwindWindowsStore.Service;
    using System.Web.Http;

    [RoutePrefix("Suppliers")]
    public class SuppliersApiController : BaseApiController
    {
        [Route("GetAll")]
        public IHttpActionResult GetAllSuppliers()
        {
            var service = new SupplierService(GetExecutingPath);
            return Ok(service.GetAll());
        }
    }
}