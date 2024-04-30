import scrapy
import requests
import time
import re

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
            yield scrapy.Request(response.urljoin(href), self.parse)
