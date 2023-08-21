using System;

namespace ComPDFKit.enums
{
    public enum CPDFDocumentAIEnum
    {
        OCR,
        MAGICCOLOR,
        TABLEREC,
        LAYOUTANALYSIS,
        DEWARP,
        DETECTIONSTAMP
    }

    public class CPDFDocumentAIEnumExtensions
    {
        public static string GetValue(CPDFDocumentAIEnum value)
        {
            return value switch
            {
                CPDFDocumentAIEnum.OCR => "documentAI/ocr",
                CPDFDocumentAIEnum.MAGICCOLOR => "documentAI/magicColor",
                CPDFDocumentAIEnum.TABLEREC => "documentAI/tableRec",
                CPDFDocumentAIEnum.LAYOUTANALYSIS => "documentAI/layoutAnalysis",
                CPDFDocumentAIEnum.DEWARP => "documentAI/dewarp",
                CPDFDocumentAIEnum.DETECTIONSTAMP => "documentAI/detectionStamp",
                _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Invalid CPDFDocumentAIEnum value")
            };
        }
    }
}
