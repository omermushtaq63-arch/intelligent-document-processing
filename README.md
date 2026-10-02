# Intelligent Document Processing

A .NET 8 API demonstrating document extraction, structured fields, confidence scoring, and chunk preparation for downstream RAG pipelines.

> Portfolio implementation based on professional experience and documented technology areas. No proprietary code or customer data is included.

## Stack
C# / .NET 8 / ASP.NET Core / OCR-ready architecture / Azure AI Services-ready / structured extraction / RAG chunking

## Run
```bash
dotnet restore
dotnet run --project src
```

## API
`POST /api/documents/process` with a JSON body containing `fileName` and `text`.

The sample uses local regex extraction so it works without cloud credentials. Production deployments can replace the extraction boundary with Azure AI Document Intelligence/OCR and semantic normalization with Azure OpenAI.

License: MIT.