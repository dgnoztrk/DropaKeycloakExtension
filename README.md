# DropaKeycloakExtension
##### Use of
###### appsettings.json
```
"KeycloakSettings": {
    "AuthorityUrl": "https://id-test.doganozturk.net/",
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
builder.Services.AddAuthorization();
app.UseAuthorization();
```

## Happy Code !
