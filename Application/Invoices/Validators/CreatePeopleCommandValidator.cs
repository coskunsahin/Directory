using Application.Invoices.Commands;
using FluentValidation;

namespace Application.Invoices.Validators
{
    public class CreatePeopleCommandValidator : AbstractValidator<CreatePeopleCommand>
    {
        public CreatePeopleCommandValidator()
        {
            RuleFor(v => v.Name).NotNull();

            // RuleFor(v => v.InvoiceItems).SetValidator(new MustHaveInvoiceItemPropertyValidator());
        }
    }
}
