# JWT Token Validation Script

This script demonstrates how to validate a JSON Web Token (JWT) using a JSON Web Key (JWK) from a specified URL. It uses the `PyJWT` library to handle token decoding, verification, and error handling. This example is particularly useful for applications that rely on an external identity provider, such as Microsoft Entra ID (formerly Azure Active Directory), where the JWK keys URL is provided.

## Requirements

- **Python 3.x**
- **PyJWT** library

To install dependencies, use:

```bash
pip install -r requirements.txt
```

## Usage

### Script Overview

The script performs the following actions:

1. Fetches JSON Web Keys (JWKs) from a specified URL.
2. Retrieves the signing key required to verify the JWT token.
3. Decodes and validates the JWT token, checking for expiration and audience.
4. Catches and handles common JWT-related exceptions.

### Code Explanation

```python
import jwt
from jwt import PyJWKClient, ExpiredSignatureError, InvalidAudienceError, InvalidSignatureError, PyJWTError

# JWT token and keys URL
token = "<token>"  # Insert your JWT token here
keys_url = "<url>"  # URL to fetch JWKs, for example:
# keys_url = "https://login.microsoftonline.com/<tenantid>/discovery/v2.0/keys"

# Create a JWK client to fetch signing keys
jwks_client = PyJWKClient(keys_url)

try:
    # Retrieve the signing key from the JWKs based on the token
    signing_key = jwks_client.get_signing_key_from_jwt(token)

    # Decode and validate the JWT token
    decoded_token = jwt.decode(
        token,
        signing_key.key,
        algorithms=["RS256"],    # Specify algorithms, e.g., RS256
        audience="<audience>",   # Replace with expected audience
        options={"verify_exp": True, "verify_aud": True}  # Enable expiration and audience verification
    )

    # Print the decoded token if it is valid
    print("Token is valid:", decoded_token)

except ExpiredSignatureError as e:
    print("Token has expired:", str(e))
except InvalidAudienceError as e:
    print("Invalid audience in token:", str(e))
except InvalidSignatureError as e:
    print("Invalid signature. The token's signature did not match:", str(e))
except jwt.DecodeError as e:
    print("Token decode error. The token could not be decoded:", str(e))
except PyJWTError as e:
    print("Token validation failed. General JWT error:", str(e))
except Exception as e:
    print("An unexpected error occurred:", str(e))
```

### Parameters

- `token`: The JWT to be validated.
- `keys_url`: The URL to fetch JWKs. For example, for Microsoft Entra ID, the format is:
  ```
  https://login.microsoftonline.com/<tenantid>/discovery/v2.0/keys
  ```
  Replace `<tenantid>` with your tenant ID.

- `audience`: The intended recipient of the token. Replace `<audience>` with the expected audience.

### Exception Handling

- `ExpiredSignatureError`: Raised when the token has expired.
- `InvalidAudienceError`: Raised when the token's audience doesn't match the expected audience.
- `InvalidSignatureError`: Raised when the token's signature does not match.
- `DecodeError`: Raised for general decoding issues.
- `PyJWTError`: Catch-all for other JWT-related errors.
- `Exception`: General exception for unexpected errors.

## Example

To use this script, substitute your actual values for `token`, `keys_url`, and `audience`:

```python
token = "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9..."  # Replace with your JWT
keys_url = "https://login.microsoftonline.com/your-tenant-id/discovery/v2.0/keys"
audience = "your-audience-identifier"
```

## Output

If the token is valid, the decoded token payload will be displayed. Otherwise, an appropriate error message will be printed based on the exception.
