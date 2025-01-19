using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Errors;
using Domain.Primitives;
using Domain.Shared;

namespace Domain.ValueObjects;

internal class Name : ValueObject
{
    public const int MaxLength = 50;

    private Name(string value)
    {
        Value = value;
    }

    public string Value { get; }

    public static Result<Name> Create(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return Result.Failure<Name>(DomainErrors.Name.Empty);
        }

        if (name.Length > MaxLength)
        {
            return Result.Failure<Name>(DomainErrors.Name.TooLong);
        }

        return new Name(name);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}
