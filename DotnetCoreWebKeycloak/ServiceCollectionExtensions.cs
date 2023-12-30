using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetCoreWebKeycloak
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// For web UI projects
        /// </summary>
        /// <param name="services"></param>
        /// <param name="keycloakSettings"></param>
        public static void AddKeycloak(this IServiceCollection services, KeycloakSettings keycloakSettings)
        {

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
            })
                .AddCookie()
                .AddOpenIdConnect(options =>
                {
                    options.Authority = keycloakSettings.Authority;
                    options.ClientId = keycloakSettings.ClientId;
                    options.ClientSecret = keycloakSettings.ClientSecret;
                    options.CallbackPath = keycloakSettings.CallbackPath;
                    options.ResponseType = keycloakSettings.ResponseType;
                    options.SaveTokens = keycloakSettings.SaveTokens;
                    options.RequireHttpsMetadata = keycloakSettings.RequireHttpsMetadata;
                });
        }
    }
}
