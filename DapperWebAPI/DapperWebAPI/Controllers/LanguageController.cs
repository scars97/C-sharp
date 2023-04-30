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
        /*private string _connection = @"Server=localhost; Database=sakila; Uid=root; Pwd=1234;";

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Models.Language> lst = null;
            using (var db = new MySqlConnection(_connection))
            {
                var sql = "select * from language";
                lst = db.Query<Models.Language>(sql);
            }
            
            return Ok(lst);
        }*/

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
        public Language GetLanguage(int languageId) 
        {
            return _languageRepository.GetLanguage(languageId);
        }

        [HttpPost]
        public void PostLanguage([FromBody]Language language) 
        {
            language.LastUpdate = DateTime.Now;
            _languageRepository.CreateLanguage(language);
        }

        [HttpPut("{languageId}")]
        public void PutLanguage(int languageId, [FromBody]Language language) 
        {
            language.LanguageId = languageId;
            language.LastUpdate = DateTime.Now;
            _languageRepository.UpdateLanguage(language);
        }

        [HttpDelete("{languageId}")]
        public void DeleteLanguage(int languageId)
        {
            _languageRepository.DeleteLanguage(languageId);
        }
    }
}
