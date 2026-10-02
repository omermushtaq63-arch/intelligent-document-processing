# Architecture

Input document/text -> extraction interface -> normalized fields + confidence -> chunking -> optional embedding/vector indexing.

Production deployments can replace the extraction boundary with Azure AI Document Intelligence/OCR and semantic normalization with Azure OpenAI.