using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySQLtest.Model
{
    [Table("language")]
    public class Language
    {
        [Key]
        [Column("language_id")]
        public int LanguageId { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
