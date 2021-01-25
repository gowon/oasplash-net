namespace OASplash.Extensible
{
    using Microsoft.Rest;

    internal class NoopCredentials : ServiceClientCredentials
    {
        public static ServiceClientCredentials Instance { get; } = new NoopCredentials();

        private NoopCredentials()
        {
        }
    }
}