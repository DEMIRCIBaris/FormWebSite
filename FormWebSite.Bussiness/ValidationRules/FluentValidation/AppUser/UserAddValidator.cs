using FluentValidation;
using FormWebSite.Entities.DTO.AppUserDTO;

namespace FormWebSite.Bussiness.ValidationRules.FluentValidation.AppUser
{
    public class UserAddValidator : AbstractValidator<UserAddDto>
    {
        public UserAddValidator()
        {
            RuleFor(i => i.UserName).NotNull().WithMessage("Kullanıcı Adı Boş olamaz");
            RuleFor(i => i.Password).NotNull().WithMessage("Parola alanı boş olamaz");
     
        }
    }
}
