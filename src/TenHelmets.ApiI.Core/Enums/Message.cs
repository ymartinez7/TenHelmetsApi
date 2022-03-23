namespace TenHelmets.API.Core.Enums
{
    public enum Message : int
    {
        Correct = 1,
        RequestError,
        InternalError,
        NullParameter,
        NotAuthorized,
        NotFound,
        InvalidModel,
        NotEqualParameter,
        UserOrPasswordInvalid,
    }
}
