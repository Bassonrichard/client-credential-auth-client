using ClientCredentialAuthClient;
using ClientCredentialAuthClient.AuthenticationStrategy;

var builder = Host.CreateApplicationBuilder(args);

var authOptions = new AuthenticationOptions();
builder.Configuration.Bind("Authentication", authOptions);



builder.Services.AddHostedService<Worker>();

var app = builder.Build();
app.Run();
