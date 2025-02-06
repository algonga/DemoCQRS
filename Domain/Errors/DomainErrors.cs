using Domain.Shared;

namespace Domain.Errors;

public static class DomainErrors
{
    public static class Email
    {
        public static readonly Error Empty = new(
            "Email.Empty",
            "Email is empty");

        public static readonly Error InvalidFormat = new(
            "Email.InvalidFormat",
            "Email format is invalid");
    }

    public static class Alumno
    {
        public static readonly Error EmailAlreadyInUse = new(
            "Member.EmailAlreadyInUse",
            "The specified email is already in use");
    }

    public static class LastName
    {
        public static readonly Error Empty = new(
            "LastName.Empty",
            "Last name is empty");

        public static readonly Error TooLong = new(
            "LastName.TooLong",
            "Last name is too long");
    }

    public static class FirstName
    {
        public static readonly Error Empty = new(
            "FirstName.Empty",
            "First name is empty");

        public static readonly Error TooLong = new(
            "FirstName.TooLong",
            "FirstName name is too long");
    }

    public static class Name
    {
        public static readonly Error Empty = new(
            "Name.Empty",
            "Asignature name is empty");

        public static readonly Error TooLong = new(
            "Name.TooLong",
            "Asignature name name is too long");
    }
}
