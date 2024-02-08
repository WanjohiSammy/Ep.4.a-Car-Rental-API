using Microsoft.Extensions.Logging;

namespace CarRental.Utility.Helpers
{
    public class NullCheckHelper
    {
        private static readonly ILogger _logger = LoggerFactory
            .Create(b => b.SetMinimumLevel(LogLevel.Information))
            .CreateLogger<NullCheckHelper>();

        public static void ThrowIfNull<T>(T paramValue)
        {
            if (paramValue is null)
            {
                var ex = new ArgumentNullException(nameof(paramValue));
                _logger.LogError("Error: {MethodName} with {Exception}.", nameof(ThrowIfNull), ex);

                throw ex;
            }
        }
    }
}
