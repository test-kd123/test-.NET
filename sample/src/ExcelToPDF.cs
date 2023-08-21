using System;
using System.IO;
using ComPDFKit.client;
using ComPDFKit.constant;
using ComPDFKit.enums;
using ComPDFKit.param;
using ComPDFKit.pojo.comPdfKit;

namespace Samples
{
    public class ExcelToPDF
    {
        private const string PublicKey = "";
        private const string SecretKey = "";
        private static readonly CPDFClient Client = new CPDFClient(PublicKey, SecretKey);

        static void Main(string[] args)
        {
            ExcelToPDFFunc();
        }

        static void ExcelToPDFFunc()
        {
            // Create Task
            CPDFCreateTaskResult createTaskResult = Client.CreateTask(CPDFConversionEnum.XLSX_TO_PDF);
            // TaskId
            string taskId = createTaskResult.TaskId;
            // Upload File
            FileInfo file = new FileInfo("sample/test.xlsx");
            string filePassword = "";
            CExcelToPDFParameter fileParameter = new CExcelToPDFParameter();
            CPDFUploadFileResult uploadFileResult = Client.UploadFile(file, taskId, fileParameter, file.Name, filePassword);
            string fileKey = uploadFileResult.FileKey;
            // Perform tasks
            Client.ExecuteTask(taskId);
            // Get task processing information
            CPDFTaskInfoResult taskInfo = Client.GetTaskInfo(taskId);
            // Determine whether the task status is "TaskFinish"
            if (taskInfo.TaskStatus.Equals(CPDFConstant.TASK_FINISH))
            {
                Console.WriteLine(taskInfo);
                // Get the final file processing information
                CPDFFileInfo fileInfo = Client.GetFileInfo(fileKey);
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