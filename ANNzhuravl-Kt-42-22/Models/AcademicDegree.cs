using ANNzhuravl_Kt_42_22.Models;

namespace ANNzhuravl_Kt_42_22.Models
{
    public class AcademicDegree
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();

    }
}