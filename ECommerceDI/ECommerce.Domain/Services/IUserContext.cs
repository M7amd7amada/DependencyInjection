namespace ECommerce.Domain.Services;

public interface IUserContext
{
    public bool IsInRole(Role role);
}

public enum Role
{
    PreferredCustomer
}