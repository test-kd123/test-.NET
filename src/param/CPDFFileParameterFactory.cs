using System;
using ComPDFKit.enums;

namespace ComPDFKit.param
{
    public static class CPDFFileParameterFactory
    {
        public static T GetFileParameterByType<T>(CPDFConversionEnum type) where T : CPDFFileParameter, new()
        {
            T CPDFFileParameter;
            switch (type)
            {
                case CPDFConversionEnum.PDF_TO_EXCEL:
                    CPDFFileParameter = new CPDFToExcelParameter() as T;
                    break;
                case CPDFConversionEnum.PDF_TO_HTML:
                    CPDFFileParameter = new CPDFToHtmlParameter() as T;
                    break;
                default:
                    throw new ArgumentException("Unsupported type: " + type);
            }
            return CPDFFileParameter;
        }

        public static T GetFileParameterByType<T>(CPDFDocumentEditorEnum type) where T : CPDFFileParameter, new()
        {
            T CPDFFileParameter;
            switch (type)
            {
                case CPDFDocumentEditorEnum.INSERT:
                    CPDFFileParameter = new CPDFPageInsertParameter() as T;
                    break;
                case CPDFDocumentEditorEnum.SPLIT:
                    CPDFFileParameter = new CPDFPageSplitParameter() as T;
                    break;
                case CPDFDocumentEditorEnum.MERGE:
                    CPDFFileParameter = new CPDFPageMergeParameter() as T;
                    break;
                case CPDFDocumentEditorEnum.COMPRESS:
                    CPDFFileParameter = new CPDFCompressParameter() as T;
                    break;
                case CPDFDocumentEditorEnum.DELETE:
                    CPDFFileParameter = new CPDFPageDeleteParameter() as T;
                    break;
                case CPDFDocumentEditorEnum.EXTRACT:
                    CPDFFileParameter = new CPDFPageExtractParameter() as T;
                    break;
                case CPDFDocumentEditorEnum.ROTATION:
                    CPDFFileParameter = new CPDFPageRotationParameter() as T;
                    break;
                case CPDFDocumentEditorEnum.ADD_WATERMARK:
                    CPDFFileParameter = new CPDFAddWatermarkParameter() as T;
                    break;
                default:
                    throw new ArgumentException("Unsupported type: " + type);
            }
            return CPDFFileParameter;
        }
    }
}