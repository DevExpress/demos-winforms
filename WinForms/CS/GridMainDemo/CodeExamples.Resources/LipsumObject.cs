// Assembly {TutorialsAssembly}
namespace DevExpress.DXperience.Demos.CodeDemo.Data {
    using DevExpress.Data;
    using DevExpress.Data.Filtering;
    using DevExpress.Data.Linq;
    using DevExpress.Data.Linq.Helpers;
    using System.Collections.Generic;
    using System.Linq;

    public class LipsumObject {
        public LipsumObject(int id) {
            this.Id = id;
        }
        public int Id {
            get;
            private set;
        }
        public string Name {
            get { return LoremIpsum.GetWord(Id); }
        }
        public string Text {
            get { return LoremIpsum.GetText(Id); }
        }
        //
        #region static
        public static IEnumerable<LipsumObject> GetRows(int count, CriteriaOperator filter, ServerModeOrderDescriptor[] orders = null) {
            var rawData = Enumerable.Range(0, count).Select(i => new LipsumObject(i))
                .AsQueryable();
            var converter = new CriteriaToExpressionConverterForObjects();
            var filtered = rawData.AppendWhere(converter, filter);
            var sorted = (orders == null) ? filtered : filtered.MakeOrderBy(converter, orders);
            return (IQueryable<LipsumObject>)sorted;
        }
        #endregion static
    }
}
