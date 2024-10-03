using System.Threading.Tasks;

namespace DownloadManager
{
    public class FileDownloadErrorException : Exception
    {
        public string FileName { get; }

        public FileDownloadErrorException(string fileName) : base($"Error occurred while downloading file: {fileName}")
        {
            FileName = fileName;
        }

        public FileDownloadErrorException(string fileName, string message)
            : base(message)
        {
            FileName = fileName;
        }

        public FileDownloadErrorException(string fileName, string message, Exception inner)
            : base(message, inner)
        {
            FileName = fileName;
        }
    }




    class Public
    {
        internal class File { }


        private static async Task<string> DownloadFileAsync(string fileName, int durationInSeconds, IProgress<int> progress = null)
        {
            try
            {

                Console.WriteLine($"Starting downloading file {fileName}");
                for (int i = 0; i<=durationInSeconds; i++)
                {
                    await Task.Delay( 1000 );
                    progress?.Report((i * 100) / durationInSeconds);
                }

                Console.WriteLine($"Completed Download for file {fileName}");

                return fileName;
            }
            catch (Exception ex)
            {
                throw new FileDownloadErrorException(fileName);
            }

        }

        static async Task Main(string[] args)
        {
            var progress = new Progress<int>(percent => Console.WriteLine($"Progress: {percent}%"));

            var downloadTasks = new Task<string>[]
            {
                DownloadFileAsync("File 1", 3, progress),
                DownloadFileAsync("File 2", 5, progress),
                DownloadFileAsync("File 3", 2, progress),
                DownloadFileAsync("File 4", 4, progress),
                DownloadFileAsync("File 5", 1, progress),
            };

            string[] downloadedFiles = await Task.WhenAll(downloadTasks);
            Console.WriteLine("All files downloaded: " + string.Join(", ", downloadedFiles));
        }
    }
}