import scrapy
import requests
import time
import re
from urllib.parse import urlparse

def is_valid_http_url(url):
    try:
        # Parse the URL
        parsed_url = urlparse(url)
        
        # Check if the scheme is either 'http' or 'https'
        if parsed_url.scheme in ("http", "https"):
            # Ensure that the URL has a network location (like a domain)
            if parsed_url.netloc:
                return True
        return False
    except Exception as e:
        print(f"An error occurred: {e}")
        return False

class AISpider(scrapy.Spider):
    name = 'AI Empower Labs Web Scraper Demo'
    start_urls = ['https://aiempowerlabs.com/']
    allowed_domains = ["aiempowerlabs.com"]

    def parse(self, response):
        print(response.url)

        webpage_request = {
            'url': response.url,
            'documentId': re.sub('[^a-zA-Z0-9-_.]', '', response.url),
            'index': "webscrape"
            }
        requests.post("http://localhost:8080/api/semantic/ingest/webpage", json=webpage_request)
        time.sleep(1) # Don't exceed rate limits

        for href in response.xpath("//a/@href").getall():
            url = response.urljoin(href)
            if is_valid_http_url(url):
                yield scrapy.Request(url, self.parse)
