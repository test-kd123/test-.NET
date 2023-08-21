namespace ComPDFKit.param
{
    public class CPDFToJpgParameter : CPDFFileParameter
    {
        /**
         * Value range 72-1500 (default 300)
         */
        private string imgDpi;

        public string GetImgDpi()
        {
            return imgDpi;
        }

        public void SetImgDpi(string imgDpi)
        {
            this.imgDpi = imgDpi;
        }
    }
}