// See https://aka.ms/new-console-template for more information
// creating and deleting files
const string filename="Testfile_New.txt";

// determine if the file exists.
Console.WriteLine(File.Exists(filename));
if(File.Exists(filename))
{
    File.Delete(filename);
}
else
{
    using(StreamWriter sw=File.CreateText(filename))
    {
        sw.WriteLine("This is a text file");
    }
}
Console.WriteLine(File.Exists(filename));

// some new filewrite methods
// todo1. Writealltext overwrites a file with the given content

if(File.Exists(filename))
{
    File.WriteAllText(filename,"This is a text file");
    File.AppendAllText(filename,"\nI'm appending text. This preserves previous content.");
}

// Get some info about the file
Console.WriteLine(File.GetCreationTime(filename));
Console.WriteLine(File.GetLastWriteTime(filename));
Console.WriteLine(File.GetLastAccessTime(filename));


// Used to set the attributes of a file. Its setting the file attributes of the file specified by the filename to be read only
// File.SetAttributes(filename,FileAttributes.ReadOnly);
// Console.WriteLine(File.GetAttributes(filename));


// We can also use the fileinfo class to get general information about the file.
try
{
    FileInfo fi=new FileInfo(filename);
    Console.WriteLine($"{fi.Length}");
    Console.WriteLine($"{fi.Directory}");
    Console.WriteLine($"{fi.IsReadOnly}");
}
catch (Exception e)
{
    Console.WriteLine($"Exception: {e}");
}

// Working with directories.
const string dirname="Testdir";
// check if the directory exists, if so create the directory otherwise delete it.
if(!Directory.Exists(dirname))
{
    Directory.CreateDirectory(dirname);
}
else
{
    Directory.Delete(dirname);
}
// Get the path for the current directory
string currpath=Directory.GetCurrentDirectory();
Console.WriteLine($"The directory of the current path is {currpath}" );

// Just like files you can retrieve info about a directory.
DirectoryInfo di=new DirectoryInfo(currpath);
Console.WriteLine($"{di.Name}");
Console.WriteLine($"{di.Parent}");
Console.WriteLine($"{di.CreationTime}");

// Enumerate the contents of directories - here we check for the directories in the current path.
/*
Directory.EnumerateFiles - goes through files in a directory
Directory.EnumerateFileSystemEntries(curpath)- all files and directories in the current path


*/
Console.WriteLine("Just Driectories: ");
List<string> thedirs=new List<string> (Directory.EnumerateDirectories(currpath));
foreach(string dir in thedirs)
{
    Console.WriteLine($"{dir}");
}
Console.WriteLine("--------------------------------");


/* challenge files and directories*/
string dir_path="C:/Users/artis/Desktop/C#_Training/CreateFilesApp/FileCollection";
List<string> files=new List<string>(Directory.EnumerateFiles(dir_path));
Console.WriteLine("Files in this directory");
int count_excel_files=0;
int count_word_files=0;

foreach(String file in files)
{
     if(file.EndsWith(".xlsx"))
     {
          count_excel_files=count_excel_files+1;

     }
     else if(file.EndsWith(".docx"))
     {
        count_word_files=count_word_files+1;
     }
    //  FileInfo file_info=new FileInfo(file);
    //  Console.WriteLine($"{file_info.Length}");
    //  Console.WriteLine($"{file_info.Attributes}");
} 

Console.WriteLine($" the number of excel files is {count_excel_files}");
Console.WriteLine($"the number of word files is {count_word_files}");
 