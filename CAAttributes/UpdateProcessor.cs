using System;

namespace CAAttributes
{
    class UpdateProcessor
    {

        // var attr =  new ObsoleteAttribute ("this method will not be supported in the next release consider using DownloadAndInstall() instead");

        [Obsolete("this method will not be supported in the next release consider using DownloadAndInstall() instead")]
        public static void Download(Update[] updates)
        {
            for (int i = 0; i < updates.Length; i++)
            {
                Console.WriteLine($"Downloading {updates[i]}");
                System.Threading.Thread.Sleep(750);
            } 
        }

        [Obsolete("this method will not be supported in the next release consider using DownloadAndInstall() instead")]

        public static void Install(Update[] updates)
        {
            for (int i = 0; i < updates.Length; i++)
            {
                Console.WriteLine($"Installing {updates[i]}");
                System.Threading.Thread.Sleep(750);
            } 
        }

        public static void DownloadAndInstall(Update[] updates)
        {
            for (int i = 0; i < updates.Length; i++)
            {
                Console.WriteLine($"Installing {updates[i]}");
                System.Threading.Thread.Sleep(750); 
                Console.WriteLine($"Downloading {updates[i]}");

            }
        }
    }
}