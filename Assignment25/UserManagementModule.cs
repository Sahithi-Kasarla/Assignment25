using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySharedLibrary;

namespace Assignment25
{
    public class UserManagementModule
    {
        public void AddUser(string username)
        {
            if (MyUtilityClass.IsDataValid(username))
            {
                MyUtilityClass.LogMessage($"User added: {username}");
                // Add your user management logic here
            }
            else
            {
                MyUtilityClass.LogMessage($"Invalid username: {username}");
            }
        }
    }
    // mainapp/FileProcessingModule.cs
    public class FileProcessingModule
    {
        public void ProcessFile(string filePath)
        {
            if (MyUtilityClass.IsDataValid(filePath))
            {
                MyUtilityClass.LogMessage($"Processing file: {filePath}");
                // Add your file processing logic here
            }
            else
            {
                MyUtilityClass.LogMessage($"Invalid file path: {filePath}");
            }
        }
    }

}
