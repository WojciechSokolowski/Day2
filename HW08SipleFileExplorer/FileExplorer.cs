using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW08SipleFileExplorer
{
    internal class FileExplorer
    {
        private string currentDirectory;

        public FileExplorer()
        {
            currentDirectory = Directory.GetCurrentDirectory();
        }

        private void DisplayDirectoryContent()
        {
            Console.WriteLine(" Directory" + currentDirectory);
            Console.WriteLine();

            try
            {
                string[] files = Directory.GetFiles(currentDirectory);
                foreach (string file in files)
                {
                    Console.WriteLine("File: " + Path.GetFileName(file));
                }

                string[] directories = Directory.GetDirectories(currentDirectory);
                foreach (string directory in directories)
                {
                    Console.WriteLine("Directory: " + Path.GetFileName(directory));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error listing directory contents: " + ex.Message);
            }
        }

        private void DisplayHelp()
        {
            Console.WriteLine("Available Commands:");
            Console.WriteLine("===================");
            Console.WriteLine("up                   - Go to the parent directory");
            Console.WriteLine("cd <directory>       - Go to the specified directory");
            Console.WriteLine("copy <source>        - Copy a file to the current directory");
            Console.WriteLine("move <source>        - Move a file to the current directory");
            Console.WriteLine("delete <file>        - Delete a file");
            Console.WriteLine("rename <file>        - Rename a file");
            Console.WriteLine("exit                 - Exit the file explorer");
            Console.WriteLine("ls                   - shows directory content");
        }

        private void CopyFile(string path)
        {
            string fileName=Path.GetFileName(path);
            string destinationPath = Path.Combine(currentDirectory, fileName);

            if (File.Exists(path)) 
            {
                try
                {
                    File.Copy(path, destinationPath);
                    Console.WriteLine("File copied");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");  
                }
            }
            else { Console.WriteLine("File does not exist"); }

        }

        private void RenameFile(string filePath)
        {
            string fileName = Path.GetFileName(filePath);
            string currentFilePath = Path.Combine(currentDirectory, fileName);

            if (File.Exists(currentFilePath))
            {
                try
                {
                    Console.Write("Enter new name for the file: ");
                    string newFileName = Console.ReadLine().Trim();
                    string newFilePath = Path.Combine(currentDirectory, newFileName);

                    if (File.Exists(newFilePath))
                    {
                        Console.WriteLine("A file with the same name already exists in the current directory.");
                        return;
                    }

                    File.Move(currentFilePath, newFilePath);
                    Console.WriteLine("File renamed successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error renaming file: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }

        private void GoToParentDirectory()
        {
            string parentDirectory = Directory.GetParent(currentDirectory)?.FullName;
            if (parentDirectory != null)
            {
                currentDirectory = parentDirectory;
                DisplayDirectoryContent();
            }
            else
            {
                Console.WriteLine("You are already at the root directory.");
            }
        }


        private void GoToDirectory(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
            {
                currentDirectory = directoryPath;
                DisplayDirectoryContent();
            }

            else
                Console.WriteLine("Invalid directory");
        }
 
        private void MoveFile(string sourcePath)
        {
            string fileName = Path.GetFileName(sourcePath);
            string destinationPath = Path.Combine(currentDirectory,fileName);

            if (File.Exists(sourcePath))
            {
                try
                {
                    File.Move(sourcePath, destinationPath);
                    Console.WriteLine("File moved successfuly");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error while moving file" + ex.Message);
                }
            }
            else 
                Console.WriteLine("File do not exist");
        }

        private void DeleteFile(string sourcePath)
        {
            string fileName = Path.GetFileName(sourcePath);
            if (File.Exists(sourcePath))
            {
                try
                {
                    File.Delete(sourcePath);
                    Console.WriteLine("File deleted");
                }
                catch (Exception ex)
                { Console.WriteLine("error during deleting: " + ex.Message); }
            }
            else
                Console.WriteLine("No such file");
        }


        public void Start()
        {
            Console.WriteLine("Simple File Explorer");
            Console.WriteLine("====================");
            Console.WriteLine("Current Directory: " + currentDirectory);
            Console.WriteLine();

            DisplayDirectoryContent();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Enter a command ('help' for commands list):");
                string command = Console.ReadLine();

                if (command == "help")
                {
                    DisplayHelp();
                }
                else if (command == "up")
                {
                    GoToParentDirectory();
                }
                else if (command.StartsWith("cd "))
                {
                    string path = command.Substring(3).Trim();
                    GoToDirectory(path);
                }
                else if (command.StartsWith("copy "))
                {
                    string sourcePath = command.Substring(5).Trim();
                    CopyFile(sourcePath);
                }
                else if (command.StartsWith("move "))
                {
                    string sourcePath = command.Substring(5).Trim();
                    MoveFile(sourcePath);
                }
                else if (command.StartsWith("delete "))
                {
                    string filePath = command.Substring(7).Trim();
                    DeleteFile(filePath);
                }
                else if (command.StartsWith("rename "))
                {
                    string sourcePath = command.Substring(7).Trim();
                    RenameFile(sourcePath);
                }
                else if (command.StartsWith("ls"))
                {
                    DisplayDirectoryContent();

                }

                else if (command == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid command.");
                }
            }


        }


    }
}
