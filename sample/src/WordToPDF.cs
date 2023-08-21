using System;
using System.IO;
using ComPDFKit.client;
using ComPDFKit.constant;
using ComPDFKit.enums;
using ComPDFKit.param;
using ComPDFKit.pojo.comPdfKit;

namespace ComPDFKit
{
    public class WordToPDF
    {
        private static readonly string publicKey = "";
        private static readonly string secretKey = "";
        private static readonly CPDFClient client = new CPDFClient(publicKey, secretKey);

        public static void Main(string[] args)
        {
            WordToPDFFunc();
        }

        public static void WordToPDFFunc()
        {
            // create Task
            CPDFCreateTaskResult createTaskResult = client.CreateTask(CPDFConversionEnum.DOCX_TO_PDF);
            // taskId
            string taskId = createTaskResult.TaskId;
            // upload File
            FileInfo file = new FileInfo("sample/test.docx");
            string filePassword = "";
            CWordToPDFParameter fileParameter = new CWordToPDFParameter();
            CPDFUploadFileResult uploadFileResult = client.UploadFile(file, taskId, fileParameter, file.Name, filePassword);
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