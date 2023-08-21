using System.Collections.Generic;

namespace ComPDFKit.param
{
    public class CPDFPageDeleteParameter : CPDFFileParameter
    {
        /// <summary>
        /// Delete the page range of the document, and the page number starts from 1.
        /// For example: 1,2,5-10 (required, the page number entered must be greater than 0 and cannot exceed the maximum page number of the document)
        /// </summary>
        private List<string> pageOptions;

        public List<string> PageOptions
        {
            get { return pageOptions; }
            set { pageOptions = value; }
        }
    }
}