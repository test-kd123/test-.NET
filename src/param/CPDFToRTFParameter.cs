﻿namespace ComPDFKit.param
{
    public class CPDFToRTFParameter : CPDFFileParameter
    {
        public static readonly string IS_CONTAIN_ANNOT = "1";
        public static readonly string NOT_IS_CONTAIN_ANNOT = "0";
        public static readonly string IS_CONTAIN_IMG = "1";
        public static readonly string NOT_IS_CONTAIN_IMG = "0";

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
    }
}