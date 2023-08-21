using System;

namespace ComPDFKit.enums
{
    public enum CPDFDocumentEditorEnum
    {
        SPLIT,
        MERGE,
        COMPRESS,
        DELETE,
        EXTRACT,
        ROTATION,
        INSERT,
        ADD_WATERMARK,
        DEL_WATERMARK
    }

    public class CPDFDocumentEditorEnumExtensions
    {
        public static string GetValue(CPDFDocumentEditorEnum value)
        {
            return value switch
            {
                CPDFDocumentEditorEnum.SPLIT => "pdf/split",
                CPDFDocumentEditorEnum.MERGE => "pdf/merge",
                CPDFDocumentEditorEnum.COMPRESS => "pdf/compress",
                CPDFDocumentEditorEnum.DELETE => "pdf/delete",
                CPDFDocumentEditorEnum.EXTRACT => "pdf/extract",
                CPDFDocumentEditorEnum.ROTATION => "pdf/rotation",
                CPDFDocumentEditorEnum.INSERT => "pdf/insert",
                CPDFDocumentEditorEnum.ADD_WATERMARK => "pdf/addWatermark",
                CPDFDocumentEditorEnum.DEL_WATERMARK => "pdf/delWatermark",
                _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Invalid CPDFDocumentEditorEnum value")
            };
        }
    }
}
