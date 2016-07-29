
namespace NorthwindWindowsStoreService.Controllers.Api.Data
{
    using NorthwindWindowsStore.Service;
    using System.Collections.Generic;
    using System.Linq;
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

        /// <summary>
        /// Get percent of employees in relation to the position
        /// </summary>
        /// <returns></returns>
        [Route("GetPercentInRelationToPosition")]
        public IHttpActionResult GetPercentInRelationToPosition()
        {
            var service = new EmployeeService(GetExecutingPath);
            return Ok(service.GetPercentInRelationToPosition());
        }
    }
}