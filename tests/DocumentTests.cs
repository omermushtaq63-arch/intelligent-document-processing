using Xunit;
using DocumentProcessing;
public class DocumentTests { [Fact] public async Task ProcessesInvoiceText(){ var p=new DocumentProcessor(); var r=await p.ProcessAsync(new DocumentRequest("invoice.txt","Invoice Number: INV-42\nVendor: Contoso\nTotal: $123.45")); Assert.NotNull(r); } }