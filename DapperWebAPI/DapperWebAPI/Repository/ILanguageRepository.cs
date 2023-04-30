using DapperWebAPI.Models;

namespace DapperWebAPI.Repository
{
    public interface ILanguageRepository
    {
        IEnumerable<Language> GetLanguages();

        Language GetLanguage(int LanguageId);

        void CreateLanguage(Language language);

        void UpdateLanguage(Language language);

        void DeleteLanguage(int LanguageId);

    }
}
