
using System.IO;
using System.Security.AccessControl;
using ExceptionProjectLibrary;

namespace FileHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //workingwithfiles();
            //WorkingwithFilesAndDirs(path);
            // WorkingwithFileandDirecInfo();

            DateTime dt = new DateTime();

            //string s = dt.ToLongDateString();
            string s = DateTime.Now.ToString("yyyy/MM/dd");
            string filename = string.Concat("CustomerLog.txt", s);

            string path = "C:\\Users\\CDAC\\Desktop\\shrushti\\DemoFiles\\" + filename+".txt";
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                Customer customer = new Customer();
                Console.WriteLine("Enter customer id:");
                customer.Custid = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Completed!!!!!");
            }
            catch (CustomerNotFoundException ex)
            {
                fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
                sw = new StreamWriter(fs);
                //Console.WriteLine(ex.Message);
                sw.WriteLine(ex.Message);

            }
            finally
            {
                sw.Flush();
                sw.Close();
                fs.Close();
                fs.Dispose();
                sw.Dispose();
            }
        }

    }
}


    //    static void WorkingwithFileandDirecInfo()
    //    {
    //        Console.WriteLine("------------File Info-----------");
    //        FileInfo f1 = new FileInfo("C:\\Users\\CDAC\\Desktop\\shrushti\\DemoFiles\\Newfile\\file1.txt");
    //        Console.WriteLine(f1.FullName);
    //        Console.WriteLine(f1.Extension);
    //        Console.WriteLine(f1.CreationTime);
    //        Console.WriteLine(f1.DirectoryName);
    //        FileSecurity fs = f1.GetAccessControl();
    //        Console.WriteLine(fs.AuditRuleType);

    //        Console.WriteLine("-----------------Directory Info-------------------");
    //        DirectoryInfo di = new DirectoryInfo("C:\\Users\\CDAC\\Desktop\\shrushti\\DemoFiles\\Newfile\\");
    //        Console.WriteLine(di.FullName);
    //        Console.WriteLine(di.Name);
    //        Console.WriteLine(di.Parent);
    //        Console.WriteLine(di.CreationTime);
    //        Console.WriteLine(di.Root);
    //    }
    //}
    //    }

//    private static void workingwithfiles()
//    {
//        string path = "C:\\Users\\CDAC\\Desktop\\shrushti\\DemoFiles\\";
//    }

//    private static void WorkingwithFilesAndDirs(string path)
//    {
//        Directory.CreateDirectory(path + "Dir1");
//        File.Move(path + "file2.txt", path + "Dir1\\file2.txt");
//        string[] files = Directory.GetFiles(path + "Dir1\\");
//        foreach (string file in files)
//        {
//            Console.WriteLine(file);
//        }
//        string fullpath = "C:\\Users\\CDAC\\Desktop\\shrushti\\FileHandling\\FileHandlingDemo\\";
//        IEnumerable<string> dirs = Directory.EnumerateDirectories(fullpath);
//        foreach (var item in dirs)
//        {
//            Console.WriteLine(item);
//        }

//        bool isFound = Directory.Exists(path);
//        Console.WriteLine(isFound);


//        string p = string.Concat(path + "file1.txt");

//        string destpath = string.Concat(path + "file2.txt");
//        File.AppendAllText(path + "file1.txt", "This is a file demo .Again Appending");
//        File.Copy(p, destpath);
//        File.Delete(path + "file2.txt");
//        string contents = File.ReadAllText(p);
//        Console.WriteLine(contents);
//        string source = path + "file1.txt";
//        string dest = path + "Newfile\\file1.txt";
//        File.Move(source, dest);
//    }
//}


//Console.WriteLine("-------------------Filestream----------");
//string path = "C:\\Users\\CDAC\\Desktop\\shrushti\\DemoFiles\\CustomerLog.txt";
//FileStream fs = null;
//StreamWriter sw = null;
//try
//{


//    Customer customer = new Customer();
//    Console.WriteLine("Enter customer id:");
//    customer.Custid = Convert.ToInt32(Console.ReadLine());


//    fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
//    sw = new StreamWriter(fs);
//    sw.WriteLine("This is a demo file using filestream");
//    sw.WriteLine("some more text..");
//    sw.WriteLine("From my point of view you should see yourself in mirrior how beautiful you are!!!");
//    Console.WriteLine("Completed!!!!!");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);

//}
//finally
//{
//    sw.Flush();
//    sw.Close();
//    fs.Close();
//    fs.Dispose();
//    sw.Dispose();
//}