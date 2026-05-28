using DevExpress.XtraCharts.Sankey;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevExpress.XtraSankey.Demos {
    public class TotalWeightComparer : IComparer<SankeyNode> {
        bool ascending;

        public TotalWeightComparer(bool ascending) {
            this.ascending = ascending;
        }

        public int Compare(SankeyNode x, SankeyNode y) {
            return (ascending ? 1 : -1) * Math.Sign(x.TotalWeight - y.TotalWeight);
        }
    }

    public class OutputLinkCountComparer : IComparer<SankeyNode> {
        bool ascending;

        public OutputLinkCountComparer(bool ascending) {
            this.ascending = ascending;
        }

        public int Compare(SankeyNode x, SankeyNode y) {
            if(x.OutputLinks.Count != 0)
                return (ascending ? 1 : -1) * Math.Sign(x.OutputLinks.Count - y.OutputLinks.Count);
            else
                return (ascending ? 1 : -1) * Math.Sign(x.InputLinks.Count - y.InputLinks.Count);
        }
    }

    public class NodeNameComparer : IComparer<SankeyNode> {
        bool ascending;

        public NodeNameComparer(bool ascending) {
            this.ascending = ascending;
        }

        public int Compare(SankeyNode x, SankeyNode y) {
            return (ascending ? 1 : -1) * x.Tag.ToString().CompareTo(y.Tag.ToString());
        }
    }
}
