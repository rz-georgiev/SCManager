using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using SCManager.Data;
using SCManager.Data.Models;
using System;
using System.Threading.Tasks;

public class QueryLoggingMiddleware(RequestDelegate next, SCManagerDbContext dbContext)
{
    private readonly RequestDelegate _next = next;
    private readonly SCManagerDbContext _dbContext = dbContext;

    public async Task InvokeAsync(HttpContext context)
    {
        // Capture the client's IP address
        var ipAddress = context.Connection.RemoteIpAddress?.ToString();

        // Capture the request path and query string
        var requestPath = context.Request.Path;
        var queryString = context.Request.QueryString.ToString();

        // Create a log entry
        var logEntry = new RequestLogEntry
        {
            IpAddress = ipAddress,
            Path = requestPath,
            QueryString = queryString,
            Timestamp = DateTime.UtcNow
        };

        // Save the log entry to the database
        _dbContext.RequestLogEntries.Add(logEntry);
        await _dbContext.SaveChangesAsync();

        // Log the information (optional)

        // Call the next middleware in the pipeline
        await _next(context);
    }
}