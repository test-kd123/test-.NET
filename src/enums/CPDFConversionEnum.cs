using System;

namespace ComPDFKit.enums
{
    public enum CPDFConversionEnum
    {
        DOC_TO_PDF,
        DOCX_TO_PDF,
        XLSX_TO_PDF,
        XLS_TO_PDF,
        PPT_TO_PDF,
        PPTX_TO_PDF,
        TXT_TO_PDF,
        PNG_TO_PDF,
        HTML_TO_PDF,
        CSV_TO_PDF,
        RTF_TO_PDF,
        PDF_TO_WORD,
        PDF_TO_EXCEL,
        PDF_TO_PPT,
        PDF_TO_TXT,
        PDF_TO_PNG,
        PDF_TO_JPG,
        PDF_TO_HTML,
        PDF_TO_RTF,
        PDF_TO_CSV
    }

    public class CPDFConversionEnumExtensions
    {
        public static string GetValue(CPDFConversionEnum value)
        {
            return value.ToString().ToLower() switch
            {
                "doc_to_pdf" => "doc/pdf",
                "docx_to_pdf" => "docx/pdf",
                "xlsx_to_pdf" => "xlsx/pdf",
                "xls_to_pdf" => "xls/pdf",
                "ppt_to_pdf" => "ppt/pdf",
                "pptx_to_pdf" => "pptx/pdf",
                "txt_to_pdf" => "txt/pdf",
                "png_to_pdf" => "png/pdf",
                "html_to_pdf" => "html/pdf",
                "csv_to_pdf" => "csv/pdf",
                "rtf_to_pdf" => "rtf/pdf",
                "pdf_to_word" => "pdf/docx",
                "pdf_to_excel" => "pdf/xlsx",
                "pdf_to_ppt" => "pdf/pptx",
                "pdf_to_txt" => "pdf/txt",
                "pdf_to_png" => "pdf/png",
                "pdf_to_jpg" => "pdf/jpg",
                "pdf_to_html" => "pdf/html",
                "pdf_to_rtf" => "pdf/rtf",
                "pdf_to_csv" => "pdf/csv",
                _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Invalid CPDFConversionEnum value")
            };
        }
    }
}
