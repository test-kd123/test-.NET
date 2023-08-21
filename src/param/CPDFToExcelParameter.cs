namespace ComPDFKit.param
{
    public class CPDFToExcelParameter : CPDFFileParameter
    {
        public static readonly string IS_CONTAIN_ANNOT = "1";
        public static readonly string NOT_IS_CONTAIN_ANNOT = "0";
        public static readonly string IS_CONTAIN_IMG = "1";
        public static readonly string NOT_IS_CONTAIN_IMG = "0";

        /**
         * extractContentOptions (1: OnlyText, 2: OnlyTable, 3: AllContent)
         */
        public string ContentOptions { get; set; }

        /**
         * createWorksheetOptions (1: ForEachTable, 2: ForEachPage, 3: ForTheDocument)
         */
        public string WorksheetOptions { get; set; }

        /**
         * Typesetting method (1: flow layout, 0: box layout) Default box layout
         */
        public string IsContainAnnot { get; set; }

        /**
         * Whether to include pictures (1: yes, 0: no)
         */
        public string IsContainImg { get; set; }
    }
}