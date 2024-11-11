# Authentication Configuration

This guide provides a detailed explanation of configuring the `appsettings.json` file to set up **JWT Bearer Authentication** in AEL Studio application. By using the `Bearer` authentication scheme and configuring Token Validation Parameters, you can secure API endpoints and enforce specific security requirements.

## Getting Started

This setup leverages the `Bearer` scheme for handling JWTs, which may be issued by an external authority, such as **Microsoft Identity Platform** (Azure AD). Below is an example configuration of `appsettings.json`, including an extensive list of Token Validation Parameters settings.

### Example `appsettings.json` Configuration

```json
{
  "Authentication": {
    "Schemes": {
      "Bearer": {
        "MetadataAddress": "https://login.microsoftonline.com/<tenant_id>/.well-known/openid-configuration",
        "RequireHttpsMetadata": "true",
        "ValidateAudience": "true",
        "Audience": "<audience>",
        "ValidateIssuer": "true",
        "ValidIssuer": "https://sts.windows.net/<tenant_id>/",
        "ValidateIssuerSigningKey": "true",
        "ValidateLifetime": "true",
        "ClockSkew": "00:05:00",
        "RequireSignedTokens": "true",
        "RequireExpirationTime": "true",
        "RoleClaimType": "roles",
        "NameClaimType": "name"
      }
    }
  }
}
```


To enable **Authorization** within the `appsettings.json` file, you'll need to include and configure the `AiStudioOptions` settings alongside the existing authentication configuration. Here’s an enhanced README section explaining how to incorporate this setting.

---

## Authorization Configuration

In addition to configuring JWT Bearer Authentication, the AEL Studio application also allows enabling authorization controls via the `AiStudioOptions` section in `appsettings.json`. This configuration lets you specify the type of authentication required for users to access certain application resources.

### Example `appsettings.json` Configuration with Authorization

To enable authorization with the `Bearer` authentication scheme, configure the `AuthenticationType` under `AiStudioOptions`. This setting ensures that the application recognizes and requires a valid JWT token to authorize access.

```json
{
  "AiStudioOptions": {
    "AuthenticationType": "OAuth"
  }
}
```

### AiStudioOptions - Configuration Parameters

#### AuthenticationType

- **Description**: Specifies the type of authentication required for API endpoints in the AEL Studio application. By setting this to `"OAuth"`, you ensure that all endpoints secured by authorization require a valid JWT token, enhancing the security and enforcing stricter access controls.
- **Example**: `"OAuth"`


### Configuration Parameters

The following are explanations of all configurable parameters in Token Validation Parameters that can be used to control JWT validation.

#### MetadataAddress

- **Description**: Specifies the URL for obtaining the OpenID Connect configuration. This URL points to the identity provider’s metadata endpoint, which contains public keys and other metadata required for validating tokens.
- **Example**: `"https://login.microsoftonline.com/{tenantId}/.well-known/openid-configuration`

#### RequireHttpsMetadata

- **Description**: Enforces HTTPS for the metadata endpoint. When set to `true`, the app will require the metadata URL to use HTTPS, improving security.
- **Example**: `"true"`

### Token Validation Options

The Token Validation Parameters allow for detailed control over JWT token validation in ASP.NET Core. Below are descriptions and examples for each parameter.

#### ValidateAudience

- **Description**: Specifies whether the `aud` claim in the token should be validated. If `true`, the application checks if the token's audience matches the expected `Audience` value.
- **Example**: `"true"`

#### Audience

- **Description**: Defines the valid audience (`aud` claim) that the token must contain to be accepted.
- **Example**: `"api://75f27b72-9a7f-4491-9dfc-a610930059e8"`

#### ValidateIssuer

- **Description**: Ensures the token's issuer (`iss` claim) matches the specified `ValidIssuer`. Set to `true` to enforce issuer validation.
- **Example**: `"true"`

#### ValidIssuer

- **Description**: Specifies the expected issuer of the token, which must match the token's `iss` claim.
- **Example**: `"https://sts.windows.net/539736c6-5f9c-4ec3-b2de-c82c12b26bcb/"`

#### ValidIssuers

- **Description**: An array of valid issuers; the token's `iss` claim must match one of these values.
- **Example**: `["https://sts.windows.net/539736c6-5f9c-4ec3-b2de-c82c12b26bcb/", "https://other-trusted-issuer.com/"]`

#### ValidateIssuerSigningKey

- **Description**: Ensures the token is signed by a trusted authority. Setting this to `true` enables validation of the signing key.
- **Example**: `"true"`

#### IssuerSigningKey

- **Description**: The specific key used to validate the token's signature. Typically used when manually specifying a signing key.
- **Example**: `new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your-secret-key"))`

#### IssuerSigningKeys

- **Description**: A collection of valid signing keys used to validate the token's signature.
- **Example**: `[key1, key2]`

#### ValidateLifetime

- **Description**: Validates the token’s expiration (`exp` claim) and rejects expired tokens. Set to `true` to enforce lifetime validation.
- **Example**: `"true"`

#### ClockSkew

- **Description**: Sets a time tolerance for the token’s expiration and issuance times to account for clock drift. Format is `hh:mm:ss`.
- **Example**: `"00:05:00"` (five-minute tolerance)

#### RequireSignedTokens

- **Description**: Ensures the token is signed; prevents accepting unsigned tokens.
- **Example**: `"true"`

#### RequireExpirationTime

- **Description**: Requires the token to have an expiration (`exp` claim). Setting this to `true` enforces that all tokens have an expiration.
- **Example**: `"true"`

#### RoleClaimType

- **Description**: Specifies the claim type to use for roles. Commonly used when tokens include roles in claims other than the default `role` claim.
- **Example**: `"roles"`

#### NameClaimType

- **Description**: Specifies the claim type to use for the name. Commonly used when tokens include a name claim other than the default `name` claim.
- **Example**: `"name"`

#### ValidateTokenReplay

- **Description**: Ensures the token is not replayed by tracking tokens used within a session.
- **Example**: `"false"`

#### TokenDecryptionKey

- **Description**: Specifies a key for decrypting tokens if they are encrypted.
- **Example**: `new SymmetricSecurityKey(Encoding.UTF8.GetBytes("decryption-key"))`

## Summary

The above configuration demonstrate how to set up and secure your AEL Studio application with JWT Bearer Authentication. By properly configuring the options in `appsettings.json`, you can enforce audience validation, issuer verification, role claims, token expiration checks, and much more to customize your authentication to meet your security needs.

---

This README should help you set up JWT authentication using the `Bearer` scheme in AEL Studio application with detailed control over token validation!
