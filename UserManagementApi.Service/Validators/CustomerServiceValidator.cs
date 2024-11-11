using FluentValidation;
using UserManagementApi.Core.Models;

namespace UserManagementApi.Service.Validators
{
    public class GetCustomerLoansValidator : AbstractValidator<string>
    {
        public GetCustomerLoansValidator()
        {
            // RuleFor(x => x.LoanId).NotEmpty();
            RuleFor(x => x).NotEmpty().Matches("^[a-zA-Z0-9]+$").WithMessage("CustomerNo must contain only alphanumeric characters.");
            // RuleFor(x => x.DatePaid).NotEmpty();
        }
    }

    public class AddNewCustomerValidator : AbstractValidator<Customer>
    {
        public AddNewCustomerValidator()
        {
            // RuleFor(x => x.LoanId).NotEmpty();
            RuleFor(x => x.Name).NotEmpty().Matches("^[a-zA-Z0-9]+$").WithMessage("CustomerNo must contain only alphanumeric characters.");
             RuleFor(x => x.Name).NotEmpty().Matches("^[a-zA-Z0-9_-]+$").WithMessage("CustomerNo can contain only alphanumeric characters, dash(-) and underscore(_)");
        }
    }
}
