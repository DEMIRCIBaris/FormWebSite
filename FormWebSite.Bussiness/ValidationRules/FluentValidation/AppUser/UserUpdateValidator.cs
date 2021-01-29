using FluentValidation;
using FormWebSite.Entities.DTO.AppUserDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormWebSite.Bussiness.ValidationRules.FluentValidation.AppUser
{
    public class UserUpdateValidator : AbstractValidator<UserUpdateDto>
    {
        public UserUpdateValidator()
        {

            RuleFor(i => i.GenderId).ExclusiveBetween(0, int.MaxValue).WithMessage("Lütfen Cinsiyet seçimi yapınız");
            RuleFor(i => i.ProgramId).ExclusiveBetween(0, int.MaxValue).WithMessage("Lütfen işiniz gereği bizzat kullandığınız bilgisayar programları yazınız.");
            RuleFor(i => i.ProgramName).NotNull().When(i => i.ProgramId == 3).WithMessage("Program adı boş olamaz");
            RuleFor(i => i.BirthDay).NotNull().WithMessage("Doğum Tarihi boş olamaz");
            RuleFor(i => i.TotalQuality).Equal(100).WithMessage("100 olmalı");
            RuleFor(i => i.aydin).Equal(true).WithMessage("Aydınlatma metinini kabul ediniz.");
            RuleFor(i => i.riza).Equal(true).WithMessage("Rıza beyanını kkabul ediniz.");

        }


    }
}
