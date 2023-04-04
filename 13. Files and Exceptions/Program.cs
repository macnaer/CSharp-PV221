using System.Text;

namespace _13._Files_and_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Files
            string path = "db.txt";
            try
            {
                using (Stream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
                {
                    string str;
                    Console.Write("Enter text: ");
                    str = Console.ReadLine();
                    byte[] buffer = Encoding.UTF8.GetBytes(str);
                    fs.Write(buffer, 0, buffer.Length);
                    fs.Close();
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