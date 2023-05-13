using System;

namespace Miro.API
{
    public class OAuthToken
    {
        public string user_id { get; set; }

        public string refresh_token { get; set; }

        public string access_token { get; set; }

        int? _expires_in;

        public int? expires_in
        {
            get
            {
                return _expires_in;
            }
            set
            {
                _expires_in = value;
                ExpireDateTime = DateTime.Now.AddSeconds(expires_in ?? 0);
            }
        }

        public string team_id { get; set; }

        public string scope { get; set; }

        public string token_type { get; set; }

        public DateTime? ExpireDateTime { get; set; } 
    }
}
