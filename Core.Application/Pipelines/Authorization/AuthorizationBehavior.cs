using MediatR;
using Microsoft.AspNetCore.Http;

namespace Core.Application.Pipelines.Authorization
{
    public class AuthorizationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>, ISecuredRequest
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AuthorizationBehavior(IHttpContextAccessor httpContextAccessor) 
        { 
            _httpContextAccessor = httpContextAccessor;
        }
        public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //add core.security.extensions
            //add core.crosscuttingconcerns.exceptions
        }
    }
}
