namespace OASplash.Abstractions
{
    public class UnsplashOptions
    {
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
        public string Version { get; set; } = "v1";
        public string BaseUri { get; set; } = "https://api.unsplash.com/";
    }
}