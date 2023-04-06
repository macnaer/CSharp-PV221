using System.Text;

namespace _13._Files_and_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Files
            //string path = "db.txt";
            //try
            //{
            //    using (Stream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            //    {
            //        string str;
            //        Console.Write("Enter text: ");
            //        str = Console.ReadLine();
            //        byte[] buffer = Encoding.UTF8.GetBytes(str);
            //        fs.Write(buffer, 0, buffer.Length);
            //        fs.Close();
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally{
            //    Console.WriteLine("Finally ");
            //}

            #endregion

            #region ClassFile
            //const string path = "db.txt";
            //string rootPath = $"C:\\";
            //string str;
            //Console.Write("Enter text: ");
            //str = Console.ReadLine();
            //File.Copy(sourceFileName: path, destFileName: "data.backup.txt", overwrite: true);
            //File.Move("data.backup.txt", "db.backup.txt", overwrite: true);
            //File.Encrypt(path);
            //File.Decrypt(path);

            //var attr = File.GetAttributes(path);
            //Console.WriteLine(attr.ToString());
            //Console.WriteLine(File.GetCreationTime(path));
            //Console.WriteLine(File.GetLastAccessTime(path));
            //Console.WriteLine(File.GetLastWriteTime(path));
            #endregion

            #region Directory
            //string rootPath = $"C:\\";
            //bool exist = Directory.Exists(rootPath);
            //if (exist)
            //{
            //    try
            //    {
            //        Console.WriteLine("Exists.");
            //        var files = Directory.EnumerateFiles(rootPath, "*.txt", SearchOption.AllDirectories);
            //        foreach (var file in files)
            //        {
            //            Console.WriteLine(file);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Directory not found!");
            //}
            #endregion

            #region ReadFile
            const string path = "db.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string fileContent = sr.ReadToEnd();
                    Console.WriteLine(fileContent);
                }
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

        }
    }
}