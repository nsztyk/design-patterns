var userType = UserType.Regular;


Creator creator = userType switch
{
    UserType.Premium => new PremiumUserCreator(),
    UserType.Regular => new RegularUserCreator(),
    _ => throw new InvalidOperationException("invalid user type")
};
