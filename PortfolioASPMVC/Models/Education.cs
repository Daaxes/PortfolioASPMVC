namespace PortfolioASPMVC.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string EducationName { get; set; }
        public string Description { get; set; }
        public string EducationType { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public List<Skill> SkillList { get; set; }
        public int SkillId { get; set; }

    }
}
