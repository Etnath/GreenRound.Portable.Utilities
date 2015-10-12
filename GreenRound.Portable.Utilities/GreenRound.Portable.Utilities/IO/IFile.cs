using System.IO;
using System.Text;

namespace GreenRound.Portable.Utilities.IO
{
    public interface IFile
    {
        StreamWriter AppendText(string path);
        StreamWriter CreateText(string path);
        StreamReader OpenText(string path);
        void Copy(string sourcePath, string destinationPath);
        void Copy(string sourcePath, string destinationPath, bool overwrite);
        bool Exists(string path);
        void Delete(string path);
        void Move(string sourceFileName, string destFileName);
        byte[] ReadAllBytes(string path);
        string ReadAllText(string path);
        string ReadAllText(string path, Encoding encoding);
        void WriteAllBytes(string path, byte[] bytes);
        void WriteAllText(string path, string contents);
        void WriteAllText(string path, string contents, Encoding encoding);

        //TODO: add FileStream class
        //public abstract FileStream Create(string path);
        //public abstract FileStream Create(string path, int bufferSize);

        //TODO: add FileStream class and FileMode enum
        //public abstract FileStream Open(string path, FileMode mode);

        //TODO: add FileStream class, FileMode enum, and FileAccess enum
        //public abstract FileStream Open(string path, FileMode mode, FileAccess access)

        //TODO: add FileStream class, FileMode enum, FileAccess enum, and FileShare enum
        //public abstract FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)

        //TODO: add FileStream class and FileOptions enum
        //public abstract FileStream Create(string path, FileOptions options);

        //TODO: add FileStream class, FileOptions enum, and FileSecurity enum
        //public abstract FileStream Create(string path, FileOptions fileOptions, FileSecurity fileSecurity);
    }
}
