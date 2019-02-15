using FiLogger.Common.Settings;

namespace FiLogger.Common.Extensions
{
    public static class SettingsExtensions
    {

        public static bool IsValid(this AppSettings data)
        {

            //TODO: Add some logging here PM 14/02/2019
            bool result = true;

            if (data == null)
            {
                result = false;
            }

            if (data.Swagger == null)
            {
                result = false;
            }

            if (data.API == null)
            {
                result = false;
            }

            if (string.IsNullOrEmpty(data.API.Title))
            {
                result = false;
                
            }

            return result;
        }
    }
}
