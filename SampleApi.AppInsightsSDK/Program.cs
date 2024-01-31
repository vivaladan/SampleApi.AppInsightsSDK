var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationInsightsTelemetry();

var app = builder.Build();

app.MapGet("/", () =>
{
    app.Logger.LogWarning("Get invoked. Using App Insights SDK");
    return "Hello World! Using App Insights SDK";
});

app.Run();