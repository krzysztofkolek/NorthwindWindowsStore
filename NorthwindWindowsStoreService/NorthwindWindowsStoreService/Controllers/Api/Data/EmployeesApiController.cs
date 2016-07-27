
namespace NorthwindWindowsStoreService.Controllers.Api.Data
{
    using NorthwindWindowsStore.Service;
    using System.Web.Http;

    [RoutePrefix("Employees")]
    public class EmployeesApiController : BaseApiController
    {
        [Route("GetAll")]
        public IHttpActionResult GetAllEmployees()
        {
            var service = new EmployeeService(GetExecutingPath);
            return Ok(service.GetAll());
        }
    }
}