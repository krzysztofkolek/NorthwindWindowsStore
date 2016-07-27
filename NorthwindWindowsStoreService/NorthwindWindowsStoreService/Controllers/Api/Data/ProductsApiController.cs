
namespace NorthwindWindowsStoreService.Controllers.Api.Data
{
    using NorthwindWindowsStore.Service;
    using System.Web.Http;

    [RoutePrefix("Products")]
    public class ProductsApiController : BaseApiController
    {
        [Route("GetAll")]
        public IHttpActionResult GetAllProducts()
        {
            var service = new ProductService(GetExecutingPath);
            return Ok(service.GetAll());
        }
    }
}