using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    public enum FileType
    {
        File,Folder
    }

    public record FileDescriptor(string Name,FileType FileType);
    public class LinuxDiskSustem
    {
        public IEnumerable<FileDescriptor> GetFileDescriptors(string path)
        {
            yield return new FileDescriptor("etc",FileType.Folder);
            yield return new FileDescriptor("home",FileType.Folder);
            yield return new FileDescriptor("demo.txt",FileType.File);
            yield return new FileDescriptor("_.json",FileType.File);
        }
        public long GetSystemTime()=>DateTime.Now.Ticks;

    }
}
