# DropaKeycloakExtension
##### Use of
###### appsettings.json
```
"KeycloakSettings": {
    "AuthorityUrl": "https://keycloak.doganozturk.net/",
    "realmName": "testRealm",
    "RequireHttpsMetadata": false,
    "ValidateIssuerSigningKey": false,
    "ValidateIssuer": false,
    "ValidateAudience": false
}
```

###### program.cs
```
using KeycloakExtension;
using KeycloakExtension.Models;
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
