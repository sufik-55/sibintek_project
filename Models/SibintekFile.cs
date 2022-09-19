
namespace sibintek_test_task.Models {

    public enum SibintekFilType{
        FOLDER,
        FILE,
    }
    public class SibintekFile {
        public int id { get; set; }
        public string name { get; set; }
        public int? parentid { get; set; }
        public SibintekFilType type { get; set; }
        public string? path { get; set; }

    }
}