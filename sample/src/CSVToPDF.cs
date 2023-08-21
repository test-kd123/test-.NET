using System;
using System.IO;
using ComPDFKit.client;
using ComPDFKit.constant;
using ComPDFKit.enums;
using ComPDFKit.param;
using ComPDFKit.pojo.comPdfKit;

namespace Samples
{
    class CSVToPDF
    {
        private const string publicKey = "";
        private const string secretKey = "";
        private static readonly CPDFClient client = new CPDFClient(publicKey, secretKey);

        static void Main(string[] args)
        {
            CSVToPDFFunc();
        }

        static void CSVToPDFFunc()
        {
            // Create Task
            CPDFCreateTaskResult createTaskResult = client.CreateTask(CPDFConversionEnum.CSV_TO_PDF);
            // TaskId
            string taskId = createTaskResult.TaskId;
            // Upload File
            FileInfo file = new FileInfo("sample/test.csv");
            string filePassword = "";
            CCSVToPDFParameter fileParameter = new CCSVToPDFParameter();
            CPDFUploadFileResult uploadFileResult = client.UploadFile(file, taskId, fileParameter, file.Name,filePassword);
            string fileKey = uploadFileResult.FileKey;
            // Perform tasks
            client.ExecuteTask(taskId);
            // Get task processing information
            CPDFTaskInfoResult taskInfo = client.GetTaskInfo(taskId);
            // Determine whether the task status is "TaskFinish"
            if (taskInfo.TaskStatus.Equals(CPDFConstant.TASK_FINISH))
            {
                Console.WriteLine(taskInfo);
                // Get the final file processing information
                CPDFFileInfo fileInfo = client.GetFileInfo(fileKey);
                Console.WriteLine(fileInfo);
                // If the task is finished, cancel the scheduled task
            }
            else
            {
                Console.WriteLine("Task incomplete processing");
            }
        }
    }
}