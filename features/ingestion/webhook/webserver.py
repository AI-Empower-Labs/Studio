import json
from http.server import BaseHTTPRequestHandler, HTTPServer

class WebRequestHandler(BaseHTTPRequestHandler):
    def do_POST(self):
        print(self.headers)

        body = b""  # Initialize an empty bytes variable to store the data

        # Handle Content-Length header case
        if "Content-Length" in self.headers:
            content_length = int(self.headers["Content-Length"])
            body = self.rfile.read(content_length)  # Read the body and store it in the variable

        # Handle Transfer-Encoding: chunked case
        elif "chunked" in self.headers.get("Transfer-Encoding", ""):
            while True:
                # Read the chunk length line and strip any whitespace
                line = self.rfile.readline().strip()
                
                # Convert the hex chunk size to an integer
                try:
                    chunk_length = int(line, 16)
                except ValueError:
                    # Handle the case where the chunk size is not valid
                    self.send_response(400, "Invalid chunk size")
                    return
                
                # If chunk length is 0, it's the end of the chunks
                if chunk_length == 0:
                    break

                # Read the chunk data based on the length
                chunk = self.rfile.read(chunk_length)
                
                # Append the chunk to the body variable
                body += chunk

                # After each chunk, there's a CRLF, so we need to read and discard it
                self.rfile.readline()  # Discard CRLF after each chunk

            # Read final empty chunk CRLF
            self.rfile.readline()

        # Parse the JSON data
        try:
            json_dict = json.loads(body)
        except json.JSONDecodeError:
            self.send_response(400)  # Bad Request
            self.send_header("Content-Type", "application/json")
            self.end_headers()
            return

        # Process the data (reverse the text)
        text = json_dict.get("text", "")

        # Convert the updated dictionary back to a JSON string
        response = {
            "replacementText": text[::-1], # Process the data (reverse the text)
            "keepOriginal": True,
            "additionalTags": {
                "ProcessedBy": ["WebHookHandler"]
            }
        }
        json_string = json.dumps(response)

        # Send the JSON response
        self.send_response(200)
        self.send_header("Content-Type", "application/json")
        self.end_headers()
        self.wfile.write(json_string.encode('utf-8'))

        print("Received:")
        print(json_dict)
        print("Responded:")
        print(json_string)


if __name__ == "__main__":
    server = HTTPServer(("0.0.0.0", 8000), WebRequestHandler)
    print("Server started on port 8000")
    server.serve_forever()
