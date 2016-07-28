namespace NorthwindWindowsStoreService.Controllers.Api
{
    using System;
    using System.Web.Http;

    [RoutePrefix("api")]
    public class BaseApiController : ApiController
    {
        protected string GetExecutingPath
        {
            get
            {
                return String.Format(@"{0}bin\App_Data", System.Web.Hosting.HostingEnvironment.MapPath("~/"));
            }
        }
    }
}