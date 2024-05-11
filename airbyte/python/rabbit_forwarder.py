import pika
import requests
import re
import json

connection = pika.BlockingConnection(
    pika.ConnectionParameters(host='localhost'))
channel = connection.channel()

result = channel.queue_declare(queue='airbyte', exclusive=False, auto_delete=False)
queue_name = result.method.queue

print(' [*] Waiting for logs. To exit press CTRL+C')

def callback(ch, method, properties, body):
    content = json.loads(body)
    text_request = {
        'documentId': re.sub('[^a-zA-Z0-9-_.]', '', content["url"]),
        'index': "nasa",
        'text': content["explanation"]
        }
    requests.post("http://localhost:8080/api/semantic/ingest/text", json=text_request)

channel.basic_consume(
    queue=queue_name, on_message_callback=callback, auto_ack=True)

channel.start_consuming()
