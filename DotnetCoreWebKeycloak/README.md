# DropaKeycloakExtension
##### Use of
###### appsettings.json
```
"KeycloakSettings": {
    "AuthorityUrl": "https://keycloak.doganozturk.net/realms/{realmName}",
    "ClientId": "webtest",
    "ClientSecret": "Nk6mtkLzbymYtGnTo0q0kXZWYc0merdF",
    "CallbackPath": "/*",
    "ResponseType": "code",
    "SaveTokens": "true",
    "RequireHttpsMetadata": "false"
}
```

###### program.cs
```
using DotnetCoreWebKeycloak;
```

###### Required
```
builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None;
});

builder.Services.AddKeycloak(builder.Configuration.GetSection("KeycloakSettings").Get<KeycloakSettings>());

app.UseAuthentication();

app.UseAuthorization();
```

## Happy Code !