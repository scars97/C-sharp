using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DapperWebAPI.Models
{
    [Table("language")]
    public class Language
    {
        public byte language_id { get; set; }

        public string? name { get; set; }

        public DateTime last_update { get; set; }

    }
}
