using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace Jira;

#nullable disable

public class JiraExamples
{
    public static async Task Run()
    {

        // Get configuration from appsettings
        // Todo add env variables

        if (string.IsNullOrEmpty(domain) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(apiKey))
        {
            Console.WriteLine("Error: Please set JIRA_DOMAIN, JIRA_EMAIL, and JIRA_API_KEY in appsettings.Development.json");
            return;
        }

        var jira = new JiraIntegration(domain, email, apiKey);

        try
        {
            // Example 1: Get open tickets
            Console.WriteLine("=== Example 1: Open Tickets ===");
            string openTickets = await jira.GetTickets("status = \"To Do\"");
            PrintTickets(openTickets);
 
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    private static void PrintTickets(string response)
    {
        try
        {
            // Console.WriteLine(response);
            using (JsonDocument doc = JsonDocument.Parse(response))
            {
                JsonElement root = doc.RootElement;
                
                if (root.TryGetProperty("issues", out JsonElement issues))
                {
                    Console.WriteLine($"Found {issues.GetArrayLength()} tickets:");
                    
                    foreach (JsonElement issue in issues.EnumerateArray())
                    {
                        string id = issue.GetProperty("id").GetString();
                        string summary = issue.GetProperty("key").GetString();
                        string status = issue.GetProperty("fields").GetProperty("status").GetProperty("name").GetString();
                        
                        Console.WriteLine($"  - ID: {id}, Key: {summary}, Status: {status}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error parsing response: {ex.Message}");
        }
    }
}
