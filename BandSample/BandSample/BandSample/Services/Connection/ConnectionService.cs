namespace BandSample.Service.Connection
{
    using Microsoft.Band.Portable;
    using System.Linq;
    using System.Threading.Tasks;

    public class ConnectionService : IConnectionService
    {
        public async Task<bool> Pair()
        {
#if __IOS__
            var manager = BandClientManager.SharedManager;
            var bandClient = manager.AttachedClients.FirstOrDefault ();
#else
#if __ANDROID__
            var pairedBands = BandClientManager.Instance.GetPairedBands();
            var bandClient = BandClientManager.Instance.Create(this, pairedBands[0]);
            var bandClient = await bandClient.ConnectTaskAsync();

#else
            var pairedBands = await BandClientManager.Instance.GetPairedBandsAsync();
            var bandClient = await BandClientManager.Instance.ConnectAsync(pairedBands.First());
#endif
            if (bandClient != null)
                return true;
#endif
            return false;
        }
    }
}
