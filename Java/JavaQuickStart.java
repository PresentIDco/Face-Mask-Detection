HttpRequest request = HttpRequest.newBuilder()
		.uri(URI.create("https://face-mask-detection.p.rapidapi.com/FaceMaskDetection"))
		.header("content-type", "application/x-www-form-urlencoded")
		.header("x-rapidapi-key", "f485496ab8msh2ea068a0bbe333cp179f86jsn2b4afe8962dd")
		.header("x-rapidapi-host", "face-mask-detection.p.rapidapi.com")
		.method("POST", HttpRequest.BodyPublishers.ofString("linkFile=%3CREQUIRED%3E"))
		.build();
HttpResponse<String> response = HttpClient.newHttpClient().send(request, HttpResponse.BodyHandlers.ofString());
System.out.println(response.body());
