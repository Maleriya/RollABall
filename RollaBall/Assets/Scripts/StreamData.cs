using System.IO;

namespace Assets.Scripts
{
    public sealed class StreamData : IData<SavedData>
    {
        public void Save(SavedData data, string path = null)
        {
            if (path == null) return;
            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine(data.Name);
                sw.WriteLine(data.Position.X);
                sw.WriteLine(data.Position.Y);
                sw.WriteLine(data.Position.Z);
                sw.WriteLine(data.IsEnabled);
            }
        }

        public SavedData Load(string path = null)
        {
            var result = new SavedData();

            using (var sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    result.Name = sr.ReadLine();
                    result.Position.X = sr.ReadLine().TrySingle();
                    result.Position.Y = sr.ReadLine().TrySingle();
                    result.Position.Z = sr.ReadLine().TrySingle();
                    result.IsEnabled = sr.ReadLine().TryBool();
                }
            }
            return result;
        }
    }

    public static class StringExtension
    {
        public static float TrySingle(this string str)
        {
            if (float.TryParse(str, out float D))
                return D;

            return 0.0f;
        }

        public static bool TryBool(this string str)
        {
            if (bool.TryParse(str, out bool D))
                return D;

            return false;
        }
    }
}
