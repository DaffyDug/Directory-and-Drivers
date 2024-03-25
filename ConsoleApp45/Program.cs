using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        DriveInfo[] driveInfos = DriveInfo.GetDrives();
        foreach (var item in driveInfos)
        {
            if (item.IsReady)
            {
                Console.WriteLine(item.RootDirectory);
            }
            if (Directory.Exists($@"{item.RootDirectory}\Windows"))
            {
                Console.WriteLine("такая папака есть");
            }
            else
            {
                Console.WriteLine("такой папки нет");
            }
        }
    }
}
public static class TOGBjhj
{
    public static long ToTb(this long b)
    {
        return b / 1000000000000;
    }
}

public static class DraverHelper
{
    public static void Avalible()
    {
        int procent;
        DriveInfo[] driveInfos = DriveInfo.GetDrives();
        foreach (var item in driveInfos)
        {
            if (item.IsReady)
            {
                procent = (int)((float)item.TotalFreeSpace / (float)item.TotalSize * 100);
                Console.WriteLine(procent);
            }
        }
    }
}


