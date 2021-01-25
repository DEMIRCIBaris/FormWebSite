using FluentValidation;
using FormWebSite.Entities.DTO.AppUserDTO;

namespace FormWebSite.Bussiness.ValidationRules.FluentValidation.AppUser
{
    public class UserSignInValidator : AbstractValidator<UserSignInDto>
    {
        public UserSignInValidator()
        {
            RuleFor(i => i.UserName).NotNull().WithMessage("Kullanıcı Adı Boş Olamaz.");
            RuleFor(i => i.Password).NotNull().WithMessage("Parola Boş Olamaz");
        }
    }
}
