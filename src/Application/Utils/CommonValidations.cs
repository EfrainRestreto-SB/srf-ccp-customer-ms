using FluentValidation;

namespace Utils.Validators
{
    public static class CommonValidations
    {
        /// <summary>
        /// Validates that a string field is required (not null or empty).
        /// </summary>
        public static IRuleBuilderOptions<T, string> Required<T>(this IRuleBuilder<T, string> ruleBuilder, string fieldName)
        {
            return ruleBuilder
                .NotEmpty().WithMessage($"The field '{fieldName}' is required.")
                .NotNull().WithMessage($"The field '{fieldName}' cannot be null.");
        }

        /// <summary>
        /// Validates that a string field has a length between min and max.
        /// </summary>
        public static IRuleBuilderOptions<T, string> LengthBetween<T>(this IRuleBuilder<T, string> ruleBuilder, int min, int max, string fieldName)
        {
            return ruleBuilder
                .Length(min, max)
                .WithMessage($"The field '{fieldName}' must be between {min} and {max} characters.");
        }

        /// <summary>
        /// Validates that a string field contains only numeric characters.
        /// </summary>
        public static IRuleBuilderOptions<T, string> MustBeNumeric<T>(this IRuleBuilder<T, string> ruleBuilder, string fieldName)
        {
            return ruleBuilder
                .Matches("^[0-9]*$").WithMessage($"The field '{fieldName}' must contain only numbers.");
        }

        /// <summary>
        /// Validates that a string field is a valid email.
        /// </summary>
        public static IRuleBuilderOptions<T, string> ValidEmail<T>(this IRuleBuilder<T, string> ruleBuilder, string fieldName)
        {
            return ruleBuilder
                .EmailAddress()
                .WithMessage($"The field '{fieldName}' must be a valid email address.");
        }

        /// <summary>
        /// Validates that a string field does not exceed the maximum length.
        /// </summary>
        public static IRuleBuilderOptions<T, string> OptionalMaxLength<T>(this IRuleBuilder<T, string> ruleBuilder, int maxLength, string fieldName)
        {
            return ruleBuilder
                .MaximumLength(maxLength)
                .WithMessage($"The field '{fieldName}' must not exceed {maxLength} characters.");
        }

        /// <summary>
        /// Validates that a string field matches a regular expression pattern.
        /// </summary>
        public static IRuleBuilderOptions<T, string> MatchesRegex<T>(this IRuleBuilder<T, string> ruleBuilder, string pattern, string fieldName, string customMessage)
        {
            return ruleBuilder
                .Matches(pattern)
                .WithMessage(customMessage ?? $"The field '{fieldName}' has an invalid format.");
        }
    }
}
