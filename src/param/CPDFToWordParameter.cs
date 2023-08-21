namespace ComPDFKit.param
{
    public class CPDFToWordParameter : CPDFFileParameter
    {
        public static readonly string IS_CONTAIN_ANNOT = "1";
        public static readonly string NOT_IS_CONTAIN_ANNOT = "0";
        public static readonly string IS_CONTAIN_IMG = "1";
        public static readonly string NOT_IS_CONTAIN_IMG = "0";
        public static readonly string IS_FLOW_LAYOUT = "1";
        public static readonly string NOT_IS_FLOW_LAYOUT = "0";

        /**
         * Typesetting method (1: flow layout, 0: box layout) Default box layout
         */
        public string IsContainAnnot {get; set;}

        /**
         * Whether to include pictures (1: yes, 0: no)
         */
        public string IsContainImg {get; set;}

        /**
         * Whether to include comments (1: Yes, 0: No)
         */
        public string IsFlowLayout {get; set;}
        
    }
}