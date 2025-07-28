namespace CyberSecurityChatbot
{
    public static class Memory
    {
        public static string UserName { get; private set; } = "friend";
        public static string FavouriteTopic { get; private set; } = null;

        public static void StoreUserName(string name)
        {
            UserName = string.IsNullOrWhiteSpace(name) ? "friend" : name;
        }

        public static void StoreFavouriteTopic(string topic)
        {
            FavouriteTopic = topic;
        }

        public static bool IsFavourite(string topic)
        {
            return !string.IsNullOrEmpty(FavouriteTopic) && FavouriteTopic == topic;
        }
    }
}
