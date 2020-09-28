using System;
using System.IO;

public class FileIO
{
    public void Ass2()
    {
        string rootFolderName = "Potato";
        Directory.CreateDirectory(rootFolderName);
        string[] subFoldersName = {"Potato",
        "bitter guard",
        "brinjal",
        "cauliflower",
        "chilly",
        "cucumber",
        "curd",
        "ghee",
        "tomato",
        "pumpkin",
        };
        foreach(string sub in subFoldersName)
        {
            string subFolderNamePath = rootFolderName + "/" + sub;
            Directory.CreateDirectory(subFolderNamePath);
            string filePath = subFolderNamePath + "/" + "Test.txt";
            File.WriteAllText(filePath,sub);
        }
    }
}