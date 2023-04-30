using Dapper;
using DapperWebAPI.Models;
using MySql.Data.MySqlClient;
using System.Linq;

namespace DapperWebAPI.Repository
{
    public class LanguageRepository : ILanguageRepository
    {

        // private IConfiguration _configuration;
        private readonly string? _connectionString;

        public LanguageRepository(IConfiguration config)
        {
            _connectionString = config["ConnectionStrings:SakilaDB"];
        }

        public IEnumerable<Language> GetLanguages()
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                var sql = @"select * from language";
                connection.Open();
                return connection.Query<Language>(sql);
            }
        }

        public Language GetLanguage(int LanguageId)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                var sql = @"select * from language where language_id = @language_id";
                connection.Open();
                return connection.QueryFirstOrDefault<Language>(
                    sql, new { language_id = LanguageId });
            }
            
        }

        public void CreateLanguage(Language language)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                var sql = @"insert into language(name,last_update) values(@name,@last_update)";
                connection.Open();
                connection.Execute(sql, new {name=language.Name, last_update=language.LastUpdate});
            }
        }

        public void UpdateLanguage(Language language)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                var sql = @"update language set name=@name, last_update=@last_update where language_id=@language_id";
                connection.Open();
                connection.Execute(sql, new { name = language.Name, last_update = language.LastUpdate, language_id=language.LanguageId });
            }
        }

        public void DeleteLanguage(int LanguageId)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                var sql = @"delete from language where language_id = @language_id";
                connection.Open();
                connection.Execute(sql, new { language_id = LanguageId });
            }
        }
    }
}
