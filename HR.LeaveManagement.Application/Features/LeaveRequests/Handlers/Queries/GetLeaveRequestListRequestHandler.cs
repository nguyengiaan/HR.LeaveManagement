using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Queries;
using HR.LeaveManagement.Application.Persistence;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Handlers.Queries
{
    public class GetLeaveRequestListRequestHandler : IRequestHandler<GetLeaveRequestListRequest, List<LeaveRequestDto>>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly Mapper _mapper;

        public GetLeaveRequestListRequestHandler(ILeaveRequestRepository leaveRequestRepository, Mapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<List<LeaveRequestDto>> Handle(GetLeaveRequestListRequest request, CancellationToken cancellationToken)
        {
            var leaveRequests = await _leaveRequestRepository.GetAll();
            return _mapper.Map<List<LeaveRequestDto>>(leaveRequests);

        }
    }
}
