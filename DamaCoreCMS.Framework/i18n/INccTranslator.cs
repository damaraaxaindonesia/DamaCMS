

namespace DamaCoreCMS.Framework.i18n
{
    public interface INccTranslator
    {
        string this[string key] { get; set; }
        string CultureCode { get; }
        string Get(string key);
        string T(string key);
        void Set(string key, string value);
        void SaveTranslations();
        INccTranslator GetTranslator(string cultureCode);
    }
}