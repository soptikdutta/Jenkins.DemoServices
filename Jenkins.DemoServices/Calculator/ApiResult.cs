using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace Calculator
{
    public class ApiResult<T> : NegotiatedContentResult<T>
    {
        private readonly string _message;

        public ApiResult(HttpStatusCode statusCode, T content, ApiController controller, string message)
            : base(statusCode, content, controller)
        {
            _message = message;
        }

        public ApiResult(HttpStatusCode statusCode, T content, IContentNegotiator contentNegotiator,
            HttpRequestMessage request, IEnumerable<MediaTypeFormatter> formatters)
            : base(statusCode, content, contentNegotiator, request, formatters)
        {
        }

        public string Message
        {
            get { return _message; }
        }


        public override async Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            HttpResponseMessage response;
            response = await base.ExecuteAsync(cancellationToken);
            response.ReasonPhrase = Message;

            if (response.StatusCode == HttpStatusCode.NoContent)
                response.Content = null;

            return response;
        }
    }
}
