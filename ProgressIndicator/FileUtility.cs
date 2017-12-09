using System.IO;
using Demo;

namespace Delegate_Events.ProgressIndicator
{
    public class FileUtility
    {
        static public void Copy(string srcPath, string dstPath, IProgressIndicator progressIndicator)
        {
            int bufferSize = 100000;
            var fi = new FileInfo(srcPath);
            var srcFile = new FileStream(srcPath, FileMode.Open);
            var dstFile = new FileStream(dstPath, FileMode.CreateNew);
            byte[] buffer = new byte[bufferSize];
            int readedSize;
            int step = 0;
            progressIndicator.Progress("Start copy", 0);
            do 
            {
                readedSize = srcFile.Read(buffer, 0, bufferSize);
                dstFile.Write(buffer, 0, bufferSize);
                step++;
                progressIndicator.Progress("Progress copy", (int) fi.Length / (step * readedSize));
            } while (readedSize != 0);
            progressIndicator.Progress("Finish copy", 100);
        }
    }
}