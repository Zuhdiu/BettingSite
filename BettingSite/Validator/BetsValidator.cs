using BettingSite.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Validator
{
    public class BetsValidator : AbstractValidator<Bets>
    {
        public BetsValidator()
        {
            RuleFor(x => x.ID).NotNull();
            RuleFor(x => x.Amount).NotNull();
            RuleFor(x => x.BetType).NotNull().MaximumLength(8);
            RuleFor(x => x.Odds).NotNull();

        }
    }
}
