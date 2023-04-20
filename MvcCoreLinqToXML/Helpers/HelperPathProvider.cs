﻿namespace MvcCoreLinqToXML.Helpers
{

    public enum Folders { Images = 0, Documents = 1 }

    public class HelperPathProvider
    {
        private IWebHostEnvironment environment;

        public HelperPathProvider(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        public string MapPath(string fileName, Folders folder)
        {
            string carpeta = "";
            if (folder == Folders.Images)
            {
                carpeta = "images";
            }
            else if (folder == Folders.Documents)
            {
                carpeta = "documents";
            }
            string path = Path.Combine(this.environment.WebRootPath
                , carpeta, fileName);
            return path;
        }
    }

}
