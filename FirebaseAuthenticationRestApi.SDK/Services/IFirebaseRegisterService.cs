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
    public interface IFirebaseRegisterService
    {
        [Post("v1/accounts:signUp")]
        Task<RegisterResponse> Register([Body]RegisterRequest registerRequest);
    }
}
