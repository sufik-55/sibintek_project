using sibintek_test_task.Models;

namespace sibintek_test_task.ViewModels {

    public class SibintekFileTree : SibintekFile{
        public List<SibintekFileTree> children { get; set; }
    }


}