﻿using FasTnT.Commands.Responses;
using FasTnT.Domain;
using FasTnT.Domain.Commands;
using FasTnT.Domain.Data;
using FasTnT.Domain.Data.Model;
using FasTnT.Model;
using FasTnT.Model.Events.Enums;
using FasTnT.Model.Exceptions;
using FasTnT.Model.MasterDatas;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FasTnT.Commands.Requests
{
    public class CaptureEpcisDocumentRequest : ICaptureRequest
    {
        public EpcisRequestHeader Header { get; set; }
        public List<EpcisEvent> EventList { get; set; } = new List<EpcisEvent>();
        public List<EpcisMasterData> MasterDataList { get; set; } = new List<EpcisMasterData>();

        public class CaptureEpcisDocumentHandler : IRequestHandler<CaptureEpcisDocumentRequest, IEpcisResponse>
        {
            private readonly RequestContext _context;
            private readonly IDocumentStore _documentStore;

            public CaptureEpcisDocumentHandler(RequestContext context, IDocumentStore documentStore)
            {
                _context = context;
                _documentStore = documentStore;
            }

            public async Task<IEpcisResponse> Handle(CaptureEpcisDocumentRequest request, CancellationToken cancellationToken)
            {
                request.EventList.ForEach(Validate);

                var captureRequest = new CaptureDocumentRequest
                {
                    Header = request.Header,
                    EventList = request.EventList,
                    MasterdataList = request.MasterDataList
                };

                await _documentStore.Capture(captureRequest, _context, cancellationToken);

                return EmptyResponse.Value;
            }

            internal static void Validate(EpcisEvent evt)
            {
                evt.Epcs.ForEach(e => UriValidator.Validate(e.Id));

                if (IsAddOrDeleteAggregation(evt) && !evt.Epcs.Any(x => x.Type == EpcType.ParentId)) // TCR-7 parentID is Populated for ADD or DELETE Actions in Aggregation Events
                {
                    throw new EpcisException(ExceptionType.ValidationException, "TCR-7: parentID must be populated for ADD or DELETE aggregation event.");
                }
            }

            private static bool IsAddOrDeleteAggregation(EpcisEvent evt) => evt.Type == EventType.Aggregation && new[] { EventAction.Add, EventAction.Delete }.Contains(evt.Action);
        }
    }
}