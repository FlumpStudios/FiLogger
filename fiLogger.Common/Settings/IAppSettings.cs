namespace FiLogger.Common.Settings
{
    public interface IAppSettings
    {
        API API { get; set; }
        Swagger Swagger { get; set; }
    }
}