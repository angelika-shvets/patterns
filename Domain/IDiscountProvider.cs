using Patterns.Domain.VisitorPattern;

namespace Patterns.Domain;

public interface IDiscountProvider
{
    Task GetMembershipDiscount(IVisitable coffee);
}