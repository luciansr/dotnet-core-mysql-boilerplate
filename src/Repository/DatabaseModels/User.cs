using System.ComponentModel.DataAnnotations;

namespace Repository.DatabaseModels
{
    internal class User
    {
        public int Id { get; set; }

        [MaxLength(128)]
        public string Username { get; set; }

        [MaxLength(128)]
        public string Name { get; set; }
    }
}