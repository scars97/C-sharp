using Dapper;
using DapperWebAPI.Models;
using DapperWebAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace DapperWebAPI.Controllers
{
    [Route("api/Language")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly ILanguageRepository _languageRepository;

        public LanguageController(ILanguageRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }

        [HttpGet]
        public IEnumerable<Language> GetLanguages()
        {
            return _languageRepository.GetLanguages();
        }

        [HttpGet("{languageId}")]
        public Language GetLanguage(byte languageId) 
        {
            return _languageRepository.GetLanguage(languageId);
        }

        [HttpPost]
        public void PostLanguage([FromBody]Language language) 
        {
            language.last_update = DateTime.Now;
            _languageRepository.CreateLanguage(language);
        }

        [HttpPut("{languageId}")]
        public void PutLanguage(byte languageId, [FromBody]Language language) 
        {
            language.language_id = languageId;
            language.last_update = DateTime.Now;
            _languageRepository.UpdateLanguage(language);
        }

        [HttpDelete("{languageId}")]
        public void DeleteLanguage(byte languageId)
        {
            _languageRepository.DeleteLanguage(languageId);
        }
    }
}
