using System;

namespace CohesionAndCoupling
{
    public static class FileName
    {
        public static string GetExtension(string fileName)
        {
            ValidateInput(fileName);

            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return null;
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetWithoutExtension(string fileName)
        {
            ValidateInput(fileName);

            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }

        private static void ValidateInput(string fileName)
        {
            if (fileName == null || fileName == string.Empty)
            {
                throw new ArgumentException("Input don't exists.");
            }
        }
    }
}
