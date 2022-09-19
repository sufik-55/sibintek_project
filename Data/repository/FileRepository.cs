using Microsoft.EntityFrameworkCore;
using sibintek_test_task.Data.DbPostgreSQL;
using sibintek_test_task.Data.interfaces;
using sibintek_test_task.Models;
using sibintek_test_task.ViewModels;
using System.Data.SqlTypes;

namespace sibintek_test_task.Data.repository {
    public class FilesRepository : ISibintekFile
    {
        private readonly AppDBContext appDBContext;

        public FilesRepository (AppDBContext appDBContext) {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<SibintekFile> allFiles {
            get {
                return GetFilesRecursive(null);        
            }
        }

        private List<SibintekFileTree> GetFilesRecursive(int? parentid) {
            List<SibintekFileTree> response =  appDBContext.SibintekFile
                .Where(p => p.parentid == parentid)
                .Select(m => new SibintekFileTree {
                        id = m.id,
                        name = m.name,
                        parentid = m.parentid,
                        path = m.path,
                        type = m.type,
                        children = new List<SibintekFileTree>()
                }).ToList();

            foreach (var r in response) {
                r.children.AddRange(GetFilesRecursive(r.id));
                //  response.children =
            }


            return response;
        }
    }
}