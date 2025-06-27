using Projects;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<pinpoint_API>("Pinpoint-API");

builder.Build().Run();
