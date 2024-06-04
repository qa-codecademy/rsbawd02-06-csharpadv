namespace MemoryManagament.Utils
{
    public class OurTextWriter : IDisposable
    {
        private string _path;
        private bool _disposedValue = false;

        private StreamWriter _streamWriter;

        public OurTextWriter(string path)
        {
            _path = path;

            _streamWriter = new StreamWriter(path);
        }

        public void WriteContent(string content)
        {
            _streamWriter.Write(content);
        }


        // Here you can clean all the members and resources which you dont need
        public void Dispose()
        {
            _streamWriter.Dispose();
            _path = null;
            _disposedValue = true;
        }
    }
}
