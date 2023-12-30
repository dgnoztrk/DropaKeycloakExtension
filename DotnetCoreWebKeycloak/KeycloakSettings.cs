namespace DotnetCoreWebKeycloak
{
    public class KeycloakSettings
    {
        public string Authority { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string CallbackPath { get; set; }
        public string ResponseType { get; set; } = "code";
        public bool SaveTokens { get; set; }
        public bool RequireHttpsMetadata { get; set; }
    }
}