using KeycloakExtension.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace KeycloakExtension
{
	public static class ServiceCollectionExtensions
	{
        public static void AddKeycloak(this IServiceCollection services, KeycloakSettings keycloakSettings)
		{
			services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
			{
				options.Authority = $"{keycloakSettings.AuthorityUrl}/realms/{keycloakSettings.realmName}";
				options.RequireHttpsMetadata = keycloakSettings.RequireHttpsMetadata;
				options.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuerSigningKey = keycloakSettings.ValidateIssuerSigningKey,
					ValidateIssuer = keycloakSettings.ValidateIssuer,
					ValidateAudience = keycloakSettings.ValidateAudience
				};
			});
		}
	}
}