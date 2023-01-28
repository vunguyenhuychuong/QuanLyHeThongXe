using BusinessObject;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Validation
{
    public class AuthValidation : AbstractValidator<StaffAccount>
    {
        public AuthValidation()
        {
            //functional programming - chi quan tam toi ket qua sau khi moi dau chấm .
            //primitive programming - viet = tay - viet if else de thuc hien viec check 
            RuleFor(x => x.Email).NotNull().NotEmpty().WithMessage("Can't be empty")
                                    .Length(20, 50).WithMessage("Must be between 20 to 50!")
                                    .Matches("@FURentalSystem.com").WithMessage("Must be use email has @FURentalSystem.com"); //func programming
            RuleFor(x => x.Password).NotNull().NotEmpty().WithMessage("Can't be empty")
                                    .Length(6, 20).WithMessage("Must be between 8 to 20!");
        }
    }
}
