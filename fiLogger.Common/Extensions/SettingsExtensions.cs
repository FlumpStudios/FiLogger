using FiLogger.Common.Settings;

namespace FiLogger.Common.Extensions
{
    public static class SettingsExtensions
    {

        /// <summary>
        /// Check the app settings exist and are correct
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool IsValid(this AppSettings data)
        {
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

            if (data.Database == null)
            {
                result = false;
            }

            if (string.IsNullOrEmpty(data.Database.ConnectionString))
            {
                result = false;
            }

            
            return result;
        }
    }
}
