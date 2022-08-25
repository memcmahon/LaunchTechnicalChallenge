using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace NearestFuelStation.FunctionalTests;

public class NearestFuelStationTests : IClassFixture<WebApplicationFactory<Program>>
{
    protected readonly HttpClient _httpClient;

    public NearestFuelStationTests(WebApplicationFactory<Program> factory)
    {
        _httpClient = factory.CreateClient();
    }

    [Fact]
    public async void UserCanVisitWelcomePage()
    {
        var response = await _httpClient.GetAsync("/");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();

        Assert.Contains("Nearest Fuel Stations", content);
        Assert.Contains("Search", content);
    }
}