namespace UCLL.Projects.WeatherStations.GraphQL.Types
{
    public class Query
    {
        public string Hello()
        {
            return "hello world";
        }

        [GraphQLDescription("Playlists hand-picked to be featured to all users.")]
        public List<Playlist> FeaturedPlaylists()
        {
            return new List<Playlist>
            {   
                new Playlist("1", "GraphQL Groovin'"),
                new Playlist("2", "Graph Explorer Jams"),
                new Playlist("3", "Interpretive GraphQL Dance")
            };
        }
    }
}
