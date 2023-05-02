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
        public IActionResult GetLanguages()
        {
            var languages = _languageRepository.GetLanguages();
            return Ok(languages);
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
