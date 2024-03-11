using MediatR;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Text;

namespace Core.Application.Pipelines.Caching
{
    public class CachingBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>, ICachableRequest
    {
        private readonly IDistributedCache _cache;
        private readonly ILogger<CachingBehaviour<TRequest, TResponse>> _logger;

        private readonly CacheSettings _cacheSettings;

        public CachingBehaviour(IDistributedCache cache, ILogger<CachingBehaviour<TRequest, TResponse>> logger, IConfiguration configuration)
        {
            _cache = cache;
            _logger = logger;
            _cacheSettings = configuration.GetSection("CacheSettings").Get<CacheSettings>(); //get error
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            TResponse response;
            
        }
    }
}
