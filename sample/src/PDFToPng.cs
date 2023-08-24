using System;
using System.IO;
using ComPDFKit.client;
using ComPDFKit.constant;
using ComPDFKit.enums;
using ComPDFKit.param;
using ComPDFKit.pojo.comPdfKit;

namespace ComPDFKit
{
    public class PDFToPng
    {
        private static readonly string publicKey = "";
        private static readonly string secretKey = "";
        private static readonly CPDFClient client = new CPDFClient(publicKey, secretKey);

        public static void Main(string[] args)
        {
            PdfToPng();
        }

        public static void PdfToPng()
        {
            // create Task
            CPDFCreateTaskResult createTaskResult = client.CreateTask(CPDFConversionEnum.PDF_TO_PNG);
            // taskId
            string taskId = createTaskResult.TaskId;
            // upload File
            FileInfo file = new FileInfo("sample/test.pdf");
            string filePassword = "";
            CPDFToPngParameter fileParameter = new CPDFToPngParameter();
            CPDFUploadFileResult uploadFileResult = client.UploadFile(file, taskId, fileParameter, filePassword);
            string fileKey = uploadFileResult.FileKey;
            // perform tasks
            client.ExecuteTask(taskId);
            // get task processing information
            CPDFTaskInfoResult taskInfo = client.GetTaskInfo(taskId);
            // determine whether the task status is "TaskFinish"
            if (taskInfo.TaskStatus.Equals(CPDFConstant.TASK_FINISH))
            {
                Console.WriteLine(taskInfo);
                // get the final file processing information
                CPDFFileInfo fileInfo = client.GetFileInfo(fileKey);
                Console.WriteLine(fileInfo);
                // if the task is finished, cancel the scheduled task
            }
            else
            {
                Console.WriteLine("Task incomplete processing");
            }
        }
    }
}