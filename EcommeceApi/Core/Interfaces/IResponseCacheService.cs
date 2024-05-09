

namespace Core.Interfaces
{
    public interface IResponseCacheService
    {
        Task CacheResponseAsync(string chacheKey, object response, TimeSpan timeToLive);
        Task<string> GetCachedResponseAsync(String cacheKey);
    }
}
