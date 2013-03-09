//Create a static class PathStorage with static methods to save and load paths from a text file.
//Use a file format of your choice.

using System;
using System.IO;
using System.Text;

static class PathStorage
{
    private static string PathToString(Path path)
    {
        StringBuilder sb = new StringBuilder();

        foreach (var item in path.PointsSequence)
        {
            sb.Append(item.X);
            sb.Append(" ");
            sb.Append(item.Y);
            sb.Append(" ");
            sb.Append(item.Z);
            sb.Append("\r\n");
        }

        return sb.ToString().TrimEnd();
    }

    private static Path StringToPath(string input)
    {
        Path path = new Path();

        string[] positions = input.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < positions.Length; i += 3)
        {
            double X = double.Parse(positions[i]);
            double Y = double.Parse(positions[i + 1]);
            double Z = double.Parse(positions[i + 2]);

            path.PointsSequence.Add(new Point3D(X, Y, Z));
        }

        return path;
    }

    public static void SavePath(Path path, string file)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write(PathToString(path));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error writing the file");
            Console.WriteLine(e.Message);
        }
    }

    public static Path LoadPath(string file)
    {
        string input = String.Empty;

        try
        {
            using (StreamReader reader = new StreamReader(file))
            {
                input = reader.ReadToEnd();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }

        return StringToPath(input);
    }
}
