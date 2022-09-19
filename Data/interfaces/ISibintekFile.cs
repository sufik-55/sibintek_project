using sibintek_test_task.Models;

namespace sibintek_test_task.Data.interfaces {
    public interface ISibintekFile {
        IEnumerable<SibintekFile> allFiles { get; }
    }
}