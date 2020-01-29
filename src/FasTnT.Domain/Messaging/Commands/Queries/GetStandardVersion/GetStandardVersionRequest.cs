﻿using FasTnT.Commands.Responses;
using FasTnT.Domain;
using FasTnT.Domain.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FasTnT.Commands.Requests
{
    public class GetStandardVersionRequest : IQueryRequest
    {
        public class GetStandardVersionHandler : IRequestHandler<GetStandardVersionRequest, IEpcisResponse>
        {
            public async Task<IEpcisResponse> Handle(GetStandardVersionRequest request, CancellationToken cancellationToken)
            {
                var result = new GetStandardVersionResponse { Version = Constants.StandardVersion };

                return await Task.FromResult(result);
            }
        }
    }
}
