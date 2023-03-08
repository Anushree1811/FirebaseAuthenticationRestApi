using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebaseAuthenticationRestApi.SDK.Requests
{
    public class RefreshRequest
    {
        [AliasAs("grant_type")]
        public string Grant_type { get; set; }

        [AliasAs("refresh_token")]
        public string Refresh_token => "refresh_token";
    }
}
