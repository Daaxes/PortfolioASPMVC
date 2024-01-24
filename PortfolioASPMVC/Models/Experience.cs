namespace PortfolioASPMVC.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string CertificateName { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public List<Skill> SkillList { get; set; }
        public int SkillId { get; set; }
    }
}
