using System.ComponentModel.DataAnnotations;

namespace Repository.DbModels
{
    public class User
    {
        public int Id { get; set; }

        [MaxLength(128)]
        public string Username { get; set; }

        [MaxLength(128)]
        public string Name { get; set; }
    }
}