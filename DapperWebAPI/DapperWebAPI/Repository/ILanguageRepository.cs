using DapperWebAPI.Models;

namespace DapperWebAPI.Repository
{
    public interface ILanguageRepository
    {
        IEnumerable<Language> GetLanguages();

        Language GetLanguage(byte LanguageId);

        void CreateLanguage(Language language);

        void UpdateLanguage(Language language);

        void DeleteLanguage(byte LanguageId);

    }
}
