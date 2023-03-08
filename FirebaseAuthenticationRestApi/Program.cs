//using FirebaseAuthentication.SDK.Extensions;
//using FirebaseAuthentication.SDK.Http;
//using FirebaseAuthentication.SDK.Requests;
//using FirebaseAuthentication.SDK.Responses;
//using FirebaseAuthentication.SDK.Services;
//using Microsoft.Extensions.DependencyInjection;
using FirebaseAuthenticationRestApi.SDK.Http;
using FirebaseAuthenticationRestApi.SDK.Requests;
using FirebaseAuthenticationRestApi.SDK.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Refit;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading.Tasks;

namespace FirebaseAuthenticationRestApi.ConsoleApp {

    class Program {

        static async Task Main(String[] args) {

            string apiKey = "AIzaSyDsRqHl36anY_xBrPOf1lzKXt4IsSDAVk8";
            string IdentityToolKitBaseUrl = "https://identitytoolkit.googleapis.com";

            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services => {

                    services.AddTransient<FirebaseApiKeyHttpMessageHandler>(s => new FirebaseApiKeyHttpMessageHandler(apiKey));


                    services.AddRefitClient<IFirebaseRegisterService>()
                    .ConfigureHttpClient(c => c.BaseAddress = new Uri(IdentityToolKitBaseUrl))
                    .AddHttpMessageHandler<FirebaseApiKeyHttpMessageHandler>();
                })
                .Build();

            host.Start();

            IFirebaseRegisterService registerService = host.Services.GetRequiredService<IFirebaseRegisterService>();
            await registerService.Register(new RegisterRequest {

                Email = "singleton@gmail.com",
                Password = "Test123!",
                ReturnSecureToken = true
            });

            Console.ReadKey();
        
        }

        //private static void AddHttpMessageHandler<T>()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
