using System.Collections.Generic;

namespace ComPDFKit.param
{
    public class CPDFPageRotationParameter : CPDFFileParameter
    {
        /**
         *  Rotate the page range of the document, and the page number starts from 1.
         *  For example: 1,2,5-10 (required, the page number entered must be greater than 0 and cannot exceed the maximum page number of the document)
         */
        public List<string> PageOptions { get; set; }

        /**
         * The rotation angle (0, 90, 180, 270) rotates clockwise
         */
        public string Rotation { get; set; }
    }
}