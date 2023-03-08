using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebaseAuthenticationRestApi.SDK.Http
{
    public class FirebaseApiKeyHttpMessageHandler : DelegatingHandler
    {
        private readonly string _apiKey;

        public FirebaseApiKeyHttpMessageHandler(string apiKey) { 
            
            _apiKey = apiKey;
        }
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.RequestUri = new Uri($"{request.RequestUri}?Key={_apiKey}");

            return base.SendAsync(request, cancellationToken);
        }
    }
}
