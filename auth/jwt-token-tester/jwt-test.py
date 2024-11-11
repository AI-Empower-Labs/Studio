import jwt

from jwt import PyJWKClient, ExpiredSignatureError, InvalidAudienceError, InvalidSignatureError, PyJWTError

# JWT token and keys URL
token = "<token>"
keys_url = "<url>"

# For example for EntraID
#keys_url = "https://login.microsoftonline.com/<tenantid>/discovery/v2.0/keys"

# Fetch the keys and create a JWK client
jwks_client = PyJWKClient(keys_url)

try:
    # Get the signing key for the token
    signing_key = jwks_client.get_signing_key_from_jwt(token)

    # Decode and validate the JWT
    decoded_token = jwt.decode(
        token,
        signing_key.key,
        algorithms=["RS256"],
        audience="<audience>",
        options={"verify_exp": True, "verify_aud": True}
    )

    # Output the decoded token
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
