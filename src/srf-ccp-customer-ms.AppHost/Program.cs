var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Core>("core");

builder.Build().Run();
