using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class JiraIntegration
{
    private readonly string _domain;
    private readonly string _email;
    private readonly string _apiKey;
    private readonly HttpClient _httpClient;

    public JiraIntegration(string domain, string email, string apiKey)
    {
        _domain = domain;
        _email = email;
        _apiKey = apiKey;
        _httpClient = new HttpClient();
    }

    /// <summary>
    /// Get tickets from Jira using JQL query
    /// </summary>
    public async Task<string> GetTickets(string jql, int maxResults = 50)
    {
        string endpoint = $"https://{_domain}/rest/api/3/search?jql={Uri.EscapeDataString(jql)}&maxResults={maxResults}";
        return await MakeRequest("GET", endpoint);
    }

    /// <summary>
    /// Get a single ticket by key
    /// </summary>
    public async Task<string> GetTicket(string ticketKey)
    {
        string endpoint = $"https://{_domain}/rest/api/3/issue/{ticketKey}";
        return await MakeRequest("GET", endpoint);
    }

    /// <summary>
    /// Create a new ticket
    /// </summary>
    public async Task<string> CreateTicket(string projectKey, string issueType, string summary, string description)
    {
        string endpoint = $"https://{_domain}/rest/api/3/issue";
        
        var payload = new
        {
            fields = new
            {
                project = new { key = projectKey },
                issuetype = new { name = issueType },
                summary = summary,
                description = description
            }
        };

        string jsonPayload = JsonSerializer.Serialize(payload);
        return await MakeRequest("POST", endpoint, jsonPayload);
    }

    /// <summary>
    /// Generic method to make HTTP requests to Jira API
    /// </summary>
    private async Task<string> MakeRequest(string method, string url, string body = null)
    {
        try
        {
            var request = new HttpRequestMessage(new HttpMethod(method), url);
            
            // Add Basic Auth header
            string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{_email}:{_apiKey}"));
            request.Headers.Add("Authorization", $"Basic {credentials}");
            request.Headers.Add("Accept", "application/json");

            if (!string.IsNullOrEmpty(body))
            {
                request.Content = new StringContent(body, Encoding.UTF8, "application/json");
            }

            var response = await _httpClient.SendAsync(request);
            string responseContent = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Jira API Error: {response.StatusCode} - {responseContent}");
            }

            return responseContent;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }
}
