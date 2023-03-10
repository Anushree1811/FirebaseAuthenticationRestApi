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
    internal interface IFirebaseLoginService
    {
        [Post("v1/accounts:signInWithPassword")]
        Task<LoginResponse> Login([Body]LoginRequest loginRequest);
    }
}
