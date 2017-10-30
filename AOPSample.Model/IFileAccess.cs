namespace AOPSample.Model
{
    public interface IFileAccess
    {
        void Create();

        void Delete();

        void Write();

        void Read();
    }
}
