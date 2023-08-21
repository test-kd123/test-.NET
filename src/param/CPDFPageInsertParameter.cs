namespace ComPDFKit.param
{
    public class CPDFPageInsertParameter : CPDFFileParameter
    {
        /// <summary>
        /// Page number
        /// </summary>
        private string targetPage;

        /// <summary>
        /// Page width (default 595)
        /// </summary>
        private string width;

        /// <summary>
        /// Page height (842)
        /// </summary>
        private string height;

        /// <summary>
        /// Number of pages to insert (default 1)
        /// </summary>
        private string number;

        public string TargetPage
        {
            get { return targetPage; }
            set { targetPage = value; }
        }

        public string Width
        {
            get { return width; }
            set { width = value; }
        }

        public string Height
        {
            get { return height; }
            set { height = value; }
        }

        public string Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}