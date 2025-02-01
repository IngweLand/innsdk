namespace Ingweland.Fog.Inn.Sdk.Authentication;

public enum AuthErrorCode
{
    None = 0,
    InvalidCredentials = 1,
    UserBanned = 2,
    UnknownResponseFormat = 3,
    NetworkError = 4,
    UnexpectedError = 5,
    UnknownResponseStatus = 6,
    EmptyResponse = 7,
    InvalidToken = 8,
    LoginUrlNotFound = 9,
}
