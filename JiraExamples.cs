using System;
using System.Text.Json;
using System.Threading.Tasks;

public class JiraExamples
{
    public static async Task Main(string[] args)
    {
        // Get configuration from environment variables
        string domain = Environment.GetEnvironmentVariable("JIRA_DOMAIN");
        string email = Environment.GetEnvironmentVariable("JIRA_EMAIL");
        string apiKey = Environment.GetEnvironmentVariable("JIRA_API_KEY");

        if (string.IsNullOrEmpty(domain) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(apiKey))
        {
            Console.WriteLine("Error: Please set JIRA_DOMAIN, JIRA_EMAIL, and JIRA_API_KEY environment variables");
            return;
        }

        var jira = new JiraIntegration(domain, email, apiKey);

        try
        {
            // Example 1: Get open tickets
            Console.WriteLine("=== Example 1: Open Tickets ===");
            string openTickets = await jira.GetTickets("status = \"To Do\"");
            PrintTickets(openTickets);

            // Example 2: Get tickets assigned to current user
            Console.WriteLine("\n=== Example 2: My Tickets ===");
            string myTickets = await jira.GetTickets("assignee = currentUser()");
            PrintTickets(myTickets);

            // Example 3: Get high priority bugs
            Console.WriteLine("\n=== Example 3: High Priority Bugs ===");
            string bugs = await jira.GetTickets("type = Bug AND priority = High AND status != Done");
            PrintTickets(bugs);

            // Example 4: Get a single ticket
            Console.WriteLine("\n=== Example 4: Single Ticket ===");
            string singleTicket = await jira.GetTicket("PROJ-123"); // Replace with actual ticket key
            Console.WriteLine(singleTicket);

            // Example 5: Create a new ticket (commented out)
            // Console.WriteLine("\n=== Example 5: Create Ticket ===");
            // string newTicket = await jira.CreateTicket("PROJ", "Bug", "New Bug", "Bug description");
            // Console.WriteLine(newTicket);
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
            using (JsonDocument doc = JsonDocument.Parse(response))
            {
                JsonElement root = doc.RootElement;
                
                if (root.TryGetProperty("issues", out JsonElement issues))
                {
                    Console.WriteLine($"Found {issues.GetArrayLength()} tickets:");
                    
                    foreach (JsonElement issue in issues.EnumerateArray())
                    {
                        string key = issue.GetProperty("key").GetString();
                        string summary = issue.GetProperty("fields").GetProperty("summary").GetString();
                        string status = issue.GetProperty("fields").GetProperty("status").GetProperty("name").GetString();
                        
                        Console.WriteLine($"  - {key}: {summary} ({status})");
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
