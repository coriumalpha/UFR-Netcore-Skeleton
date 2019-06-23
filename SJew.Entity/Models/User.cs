using URF.Core.EF.Trackable;

namespace SJew.Data.Models
{
    public partial class User : Entity
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
    }
}
