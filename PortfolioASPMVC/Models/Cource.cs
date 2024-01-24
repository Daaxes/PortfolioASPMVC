namespace PortfolioASPMVC.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public List<Skill> SkillList { get; set; }
        public int SkillId { get; set; }



    }
}
