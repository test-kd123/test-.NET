namespace ComPDFKit.param
{
    public class CPDFToHtmlParameter : CPDFFileParameter
    {
        public static readonly string IS_CONTAIN_ANNOT = "1";
        public static readonly string NOT_IS_CONTAIN_ANNOT = "0";
        public static readonly string IS_CONTAIN_IMG = "1";
        public static readonly string NOT_IS_CONTAIN_IMG = "0";

        public static readonly string SinglePage = "1";
        public static readonly string SinglePageNavigationByBookmarks = "2";
        public static readonly string MultiplePages = "3";
        public static readonly string MultiplePagesSplitByBookmarks = "4";

        /**
         * pageOptions 1: SinglePage, 2: SinglePageNavigationByBookmarks, 3: MultiplePages, 4: MultiplePagesSplitByBookmarks
         */
        private string pageOptions;

        /**
         * Typesetting method (1: flow layout, 0: box layout) Default box layout
         */
        private string isContainAnnot;

        /**
         * Whether to include pictures (1: yes, 0: no)
         */
        private string isContainImg;

        public string GetIsContainAnnot()
        {
            return isContainAnnot;
        }

        public void SetIsContainAnnot(string isContainAnnot)
        {
            this.isContainAnnot = isContainAnnot;
        }

        public string GetIsContainImg()
        {
            return isContainImg;
        }

        public void SetIsContainImg(string isContainImg)
        {
            this.isContainImg = isContainImg;
        }

        public string GetPageOptions()
        {
            return pageOptions;
        }

        public void SetPageOptions(string pageOptions)
        {
            this.pageOptions = pageOptions;
        }
    }
}