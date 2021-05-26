import requests (From Rapidapi.com)

url = "https://face-mask-detection.p.rapidapi.com/FaceMaskDetection"

payload = "imageBase64=%3CREQUIRED%3E"
headers = {
    'content-type': "application/x-www-form-urlencoded",
    'x-rapidapi-key': "Rapidapi key",
    'x-rapidapi-host': "face-mask-detection.p.rapidapi.com"
    }

response = requests.request("POST", url, data=payload, headers=headers)

print(response.text)
