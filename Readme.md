<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595388/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T581087)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Program.cs](./CS/CopyPage/Program.cs) (VB: [Program.vb](./VB/CopyPage/Program.vb))
<!-- default file list end -->
# PDF Document API - Copy Pages from One Document to Another


This example shows how to extract a page from one PDF document and insert it to another PDF. 


<h3>Description</h3>

To accomplish this task:<br>-&nbsp;Create two&nbsp;<a href="https://documentation.devexpress.com/DocumentServer/DevExpress.Pdf.PdfDocumentProcessor.class">PdfDocumentProcessor</a> instances;<br>- Load&nbsp;a source document to the first&nbsp;instance and the&nbsp;target document to the second&nbsp;by calling the <a href="https://documentation.devexpress.com/DocumentServer/DevExpress.Pdf.PdfDocumentProcessor.LoadDocument.overloads">PdfDocumentProcessor.LoadDocument</a> overload method;<br>- Retrieve the&nbsp;page&nbsp; within&nbsp;the source document using the <a href="https://documentation.devexpress.com/CoreLibraries/DevExpress.Pdf.PdfDocument.Pages.property">PdfDocument.Pages </a>property. To access the document,&nbsp;use the <a href="https://documentation.devexpress.com/DocumentServer/DevExpress.Pdf.PdfDocumentProcessor.Document.property">PdfDocumentProcessor.Document </a>property;<br>- Insert the extracted&nbsp;page to the&nbsp;page collection of the target document&nbsp;using the <strong>Insert</strong> method;<br>- Save the resulting document by&nbsp;calling the<a href="https://documentation.devexpress.com/DocumentServer/DevExpress.Pdf.PdfDocumentProcessor.SaveDocument.overloads"> PdfDocumentProcessor.SaveDocument</a> overload method.

<br/>


