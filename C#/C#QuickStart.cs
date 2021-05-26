var client = new HttpClient();
var request = new HttpRequestMessage
{
    Method = HttpMethod.Post,
    RequestUri = new Uri("https://face-mask-detection.p.rapidapi.com/FaceMaskDetection"),
    Headers =
    {
        { "x-rapidapi-key", "APIKEY" },
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
