var client = new HttpClient();
var request = new HttpRequestMessage
{
    Method = HttpMethod.Post,
    RequestUri = new Uri("https://face-mask-detection.p.rapidapi.com/FaceMaskDetection"),
    Headers =
    {
        { "x-rapidapi-key", "f485496ab8msh2ea068a0bbe333cp179f86jsn2b4afe8962dd" },
        { "x-rapidapi-host", "face-mask-detection.p.rapidapi.com" },
    },
    Content = new FormUrlEncodedContent(new Dictionary<string, string>
    {
        { "linkFile", "<REQUIRED>" },
    }),
};
using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    var body = await response.Content.ReadAsStringAsync();
    Console.WriteLine(body);
}
