namespace OASplash.Abstractions
{
    public class UnsplashOptions
    {
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
        public string Version { get; set; } = "v1";
        public string BaseUri { get; set; } = "https://api.unsplash.com/";
        public int MaxAuthorizationRetries { get; set; } = 1;
        public string OAuthAuthorizeUri { get; set; } = "https://unsplash.com/oauth/authorize";
        public string OAuthRedirectUri { get; set; } = "urn:ietf:wg:oauth:2.0:oob";
        public string OAuthTokenUri { get; set; } = "https://unsplash.com/oauth/token";
    }
}