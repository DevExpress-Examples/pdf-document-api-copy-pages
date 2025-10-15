<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595388/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T581087)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# PDF Document API - Copy Pages from One Document to Another

This example shows how to extract a page from one PDF document and insert it to another PDF.

> [!Important]  
> The Universal Subscription or an additional Office File API Subscription is required to use this example in production code. For pricing information, please refer to the [DevExpress Subscription](https://www.devexpress.com/Subscriptions/) page.

## Implementation Details

To accomplish this task:

* Create two [PdfDocumentProcessor](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor) instances.
* Call the [PdfDocumentProcessor.LoadDocument](https://docs.devexpress.com/OfficeFileAPI/devexpress.pdf.pdfdocumentprocessor.loaddocument.overloads) method to load a source document to the first instance and the target document to the second instance.
* Use the [PdfDocument.Pages](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocument.Pages) property to retrieve the page in the source document. To obtain the document, use the [PdfDocumentProcessor.Document](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.Document) property.
* Insert the extracted page to the page collection of the target document by the **Insert** method call.
* Save the resulting document by the [PdfDocumentProcessor.SaveDocument](https://docs.devexpress.com/OfficeFileAPI/devexpress.pdf.pdfdocumentprocessor.savedocument.overloads) method call.

## Files to Review

* [Program.cs](./CS/CopyPage/Program.cs) (VB: [Program.vb](./VB/CopyPage/Program.vb))

## Documentation

* [Organize Pages in PDF Documents](https://docs.devexpress.com/OfficeFileAPI/119762/pdf-document-api/document-manipulation/page-manipulation)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-copy-pages&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-copy-pages&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
