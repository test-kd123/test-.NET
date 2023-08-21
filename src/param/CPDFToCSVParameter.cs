namespace ComPDFKit.param
{
    public class CPDFToCSVParameter : CPDFFileParameter
    {
        public static readonly string IS_CSV_MERGE = "1";
        public static readonly string NOT_IS_CSV_MERGE = "0";

        /**
         * Whether to merge CSV (1: Yes, 0: No)
         */
        private string isCsvMerge;

        public string GetIsCsvMerge()
        {
            return isCsvMerge;
        }

        public void SetIsCsvMerge(string isCsvMerge)
        {
            this.isCsvMerge = isCsvMerge;
        }
    }
}