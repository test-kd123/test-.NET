## ComPDFKit API in Java

[ComPDFKit](https://api.compdf.com/api/docs/introduction) API provides a variety of CSharp API tools that allow you to create an efficient document processing workflow in a single API call. Try our various APIs for free — no credit card required.



## Requirements

Programming Environment: .NET Framework 4.5.2 or above or .NET Core 2.0 or above.

Dependencies: Nuget



## Installation

You can install the library via NuGet Package Manager, or run the following command in the Package Manager Console:
``` shell script
Install-Package ComPDFKit.Api
```
Alternatively, you can add "ComPDFKit.Api": "1.3.2" to your .csproj file and then run.



## Create API Client

You can use your **publicKey** and **secretKey** to complete the authentication. You need to [sign in](https://api.compdf.com/login) your ComPDFKit API account to get your **publicKey** and **secretKey** at the [dashboard](https://api-dashboard.compdf.com/api/keys). If you are new to ComPDFKit, click here to [sign up](https://api.compdf.com/signup) for a free trial.

- Project public Key : You can find the public key in [Management Panel](https://api-dashboard.compdf.com/api/keys).

- Project secret Key : You can find the secret Key in [Management Panel](https://api-dashboard.compdf.com/api/keys).

```csharp
CPDFClient client = new CPDFClient(<publicKey>, <secretKey>);
```



## Create Task

A task ID is automatically generated for you based on the type of PDF tool you choose. You can provide the callback notification URL. After the task processing is completed, we will notify you of the task result through the callback interface. You can perform other operations according to the request result, such as checking the status of the task, uploading files, starting the task, or downloading the result file.

```csharp
// Create a client
CPDFClient client = new CPDFClient(<publicKey>, <secretKey>);

// Create a task
// Create an example of a PDF TO WORD task
CPDFCreateTaskResult result = client.CreateTask(CPDFConversionEnum.PDF_TO_WORD);

// Get a task id
string taskId = result.TaskId;
```



## Upload Files

Upload the original file and bind the file to the task ID. The field parameter is used to pass the JSON string to set the processing parameters for the file. Each file will generate automatically a unique filekey. Please note that a maximum of five files can be uploaded for a task ID and no files can be uploaded for that task after it has started.

```csharp
// Create a client
CPDFClient client = new CPDFClient(<publicKey>, <secretKey>);

// Create a task
// Create an example of a PDF TO WORD task
CPDFCreateTaskResult result = client.CreateTask(CPDFConversionEnum.PDF_TO_WORD);

// Get a task id
string taskId = result.TaskId;

// Upload files
client.UploadFile(<convertFile>, taskId);
```



## Execute the task

After the file upload is completed, call this interface with the task ID to process the files.

```csharp
// Create a client
CPDFClient client = new CPDFClient(<publicKey>, <secretKey>);

// Create a task
// Create an example of a PDF TO WORD task
CPDFCreateTaskResult result = client.CreateTask(CPDFConversionEnum.PDF_TO_WORD);

// Get a task id
string taskId = result.TaskId;

// Upload files
client.UploadFile(<convertFile>, taskId);

// execute Task
client.ExecuteTask(taskId, CPDFLanguageConstant.English);
```



## Get Task Info

Request task status and file-related meta data based on the task ID.

```csharp
// Create a client
CPDFClient client = new CPDFClient(<publicKey>, <secretKey>);

// Create a task
// Create an example of a PDF TO WORD task
CPDFCreateTaskResult result = client.CreateTask(CPDFConversionEnum.PDF_TO_WORD);

// Get a task id
string taskId = result.TaskId;

// Upload files
client.UploadFile(<convertFile>, taskId);

// execute Task
client.ExecuteTask(taskId, CPDFLanguageConstant.English);

// Query TaskInfo
CPDFTaskInfoResult taskInfo = client.GetTaskInfo(taskId);
```



## Samples

See ***"Samples"*** folder in this folder.



## Resources

* [ComPDFKit API Documentation](https://api.compdf.com/api/docs/introduction)
