﻿namespace ZuneSearchClient
{
    internal class Constants
    {
        internal const string SearchUrlFormat = "http://cdn.marketplaceedgeservice.windowsphone.com/v8/catalog/queries?os=8.0.9903.0&zLocale=en-US&cc=US&oc=&lang=en-US&hw=469800450&dm=Virtual&prefix={0}&chunksize=4&includeApplications={1}&includeAlbums={2}&includeArtists={3}&includeTracks={4}&includePodcasts={5}&cf=";
        internal const string SearchUrlFormatSecondary = "http://catalog.zune.net/v3.2/en-US/music/{0}/?chunksize=20&isActionable=true&q={1}";
        internal const string ArtistUrlFormat = "http://catalog.zune.net/v3.2/en-US/music/artist/{0}/{1}";
        internal const string AlbumUrlFormat = "http://catalog.zune.net/v3.2/en-US/music/album/{0}";
        internal const string AlbumArtUrlFormat = "http://image.catalog.zune.net/v3.2/en-US/image/{0}?width=320&height=320&resize=true&contenttype=image/jpeg";
        internal const string ArtistBackgroundUrlFormat = "http://image.catalog.zune.net/v3.2/en-US/music/artist/{0}/primaryimage?height={1}&contenttype=image/jpeg&resize=true";
    }
}
