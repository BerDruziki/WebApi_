using Microsoft.AspNetCore.Identity;
using FluentValidation;
using FluentValidation.Results;

public class userValidator : AbstractValidator<User>
{
    public userValidator()
    {
        RuleFor(x => x.name)
        .NotEmpty()
        .NotNull()
        .Length(3, 60);
    }
}