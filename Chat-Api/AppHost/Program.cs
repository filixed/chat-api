var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Host>("chat-api");

builder.Build().Run();
