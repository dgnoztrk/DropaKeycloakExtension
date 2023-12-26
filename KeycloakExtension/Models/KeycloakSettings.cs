namespace KeycloakExtension.Models
{
	public class KeycloakSettings
	{
		public string AuthorityUrl { get; set; }
		public string realmName { get; set; }
        public bool RequireHttpsMetadata { get; set; }
        public bool ValidateIssuerSigningKey { get; set; }
        public bool ValidateIssuer { get; set; }
        public bool ValidateAudience { get; set; }
    }
}