using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Calculator
{
    public static class ControllerExtension
    {
        public static async Task<ApiResult<T>> CreateResponse<T>(this ApiController controller, T content, string message = null)
        {
            var result = await Task.Run(() =>
            {
                return new ApiResult<T>(HttpStatusCode.OK, content, controller, message);
            });
            return result;

        }

        /*private static HttpStatusCode ConvertStatusCode(ServiceStatus statusCode)
        {
            switch (statusCode)
            {
                case ServiceStatus.Success:
                    return HttpStatusCode.OK;
                case ServiceStatus.InvalidRequest:
                    return HttpStatusCode.BadRequest;
                case ServiceStatus.Exception:
                    return HttpStatusCode.InternalServerError;
                case ServiceStatus.Accepted:
                    return HttpStatusCode.Accepted;
                case ServiceStatus.Created:
                    return HttpStatusCode.Created;
                case ServiceStatus.Deleted:
                    return HttpStatusCode.NoContent;
                case ServiceStatus.DataNotFound:
                    return HttpStatusCode.NotFound;
                case ServiceStatus.BadRequest:
                    return HttpStatusCode.BadRequest;
                case ServiceStatus.Gone:
                    return HttpStatusCode.Gone;
                case ServiceStatus.Unauthorized:
                    return HttpStatusCode.Unauthorized;
                case ServiceStatus.NoContent:
                    return HttpStatusCode.NoContent;
                case ServiceStatus.PreCondition:
                    return HttpStatusCode.PreconditionFailed;
                case ServiceStatus.CardInactive:
                    return (HttpStatusCode)418;
                case ServiceStatus.TooManyInquries:
                    return (HttpStatusCode)429;
                case ServiceStatus.BadGateway:
                    return HttpStatusCode.BadGateway;


                default:
                    throw new NotImplementedException();
            }
        }*/
    }
}
