using System.Net;

namespace Task1.LightHTML.Elements.Image.LoadingStrategy;

public class LightNetworkImageLoading : LightImageLoading
{
    public override byte[] LoadImage(string href)
    {
        // Load image form the network
        using (var client = new WebClient())
        {
            return client.DownloadData(href);
        }
    }
}