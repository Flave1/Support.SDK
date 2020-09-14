using System;
using System.Collections.Generic;
using System.Text;

namespace Support.SDK
{
    public class UriService : IUriService
    {
        private readonly string _baseUri;
        public UriService(string baseUri)
        {
            _baseUri = baseUri;
        }

        public Uri ReturnCompanyBaseDomain(string clientPath)
        {
            return new Uri(_baseUri + clientPath);
        }
    }
    public interface IUriService
    {
        Uri ReturnCompanyBaseDomain(string clientPath);
    }
}
