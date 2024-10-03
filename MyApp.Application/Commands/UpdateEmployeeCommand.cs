using MediatR;
using MyApp.Core.Entity;
using MyApp.Core.Interfaces;

namespace MyApp.Application.Commands
{
    public record UpdateEmployeeCommand(Guid EmployeeId, EmployeeEntity Employee) :
        IRequest<EmployeeEntity>;
    public class UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository) :
        IRequestHandler<UpdateEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.UpdateEmployeeAsync(request.EmployeeId,request.Employee);
        }
    }
}
