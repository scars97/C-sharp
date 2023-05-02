using Dapper;
using DapperWebAPI.Models;
using MySql.Data.MySqlClient;
using System.Linq;

namespace DapperWebAPI.Repository
{
    public class LanguageRepository : ILanguageRepository
    {

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

        public Language GetLanguage(byte LanguageId)
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
                connection.Execute(sql, new {name=language.name, last_update=language.last_update});
            }
        }

        public void UpdateLanguage(Language language)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                var sql = @"update language set name=@name, last_update=@last_update where language_id=@language_id";
                connection.Open();
                connection.Execute(sql, new { name = language.name, last_update = language.last_update, language_id=language.language_id });
            }
        }

        public void DeleteLanguage(byte LanguageId)
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
