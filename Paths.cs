using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoneCleaner
{
    class Paths
    {
        public static string ProgramFiles64 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles);
        public static string ProgramFiles86 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFilesX86);

        public static string UserDir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);
        public static string Personal = System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);
        public static string MyDocs = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
        public static string MyMusic = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyMusic);
        public static string MyPics = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures);
        public static string MyVideo = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyVideos);

        public static string Favorites = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Favorites);
    }
}
