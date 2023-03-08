using FirebaseAuthenticationRestApi.SDK.Requests;
using FirebaseAuthenticationRestApi.SDK.Responses;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebaseAuthenticationRestApi.SDK.Services
{
    public interface IFirebaseRefreshService
    {
        [Post("v1/token")]
        Task<RefreshResponse> Refresh([Body(BodySerializationMethod.UrlEncoded)]RefreshRequest refreshRequest);
    }
}
