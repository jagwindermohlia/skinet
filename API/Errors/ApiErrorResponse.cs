using System;

namespace API.Errors;

public class ApiErrorResponse(int statusCode, string message, string details)
{
    public int StatsCode { get; set; } = statusCode;
    public string Message { get; set; } = message;
    public string? Details { get; set; } = details;
}
