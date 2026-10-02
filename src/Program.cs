using DocumentProcessing;

var b = WebApplication.CreateBuilder(args);
b.Services.AddSingleton<DocumentProcessor>();
b.Services.AddEndpointsApiExplorer();
b.Services.AddSwaggerGen();

var app = b.Build();
if (app.Environment.IsDevelopment()) { app.UseSwagger(); app.UseSwaggerUI(); }

app.MapGet("/health", () => new { status = "healthy", service = "document-processing" });
app.MapPost("/api/documents/process", async (DocumentRequest req, DocumentProcessor p) =>
    Results.Ok(await p.ProcessAsync(req)));

app.Run();
public record DocumentRequest(string FileName, string Text);