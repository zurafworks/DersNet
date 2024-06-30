using StackExchange.Redis;

namespace WebAPI.Helpers.Caching;

public static class CacheHelper
{
    /// <summary>
    /// Eğer redis sunucusu ayakta değilse InMemoryDb kullanması için yazıldı.
    /// </summary>
    /// <param name="connectionString"></param>
    /// <returns></returns>
    public static bool CheckRedisAvailability(string connectionString)
    {
        try
        {
            ConnectionMultiplexer.ConnectAsync(connectionString).GetAwaiter().GetResult();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
}
