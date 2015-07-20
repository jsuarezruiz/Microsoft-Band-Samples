namespace BandSample.Service.Connection
{
    using System.Threading.Tasks;

    public interface IConnectionService
    {
        Task<bool> Pair();
    }
}
