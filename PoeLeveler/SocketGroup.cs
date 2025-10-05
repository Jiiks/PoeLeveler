using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeLeveler;
public partial class SocketGroup : FlowLayoutPanel {
    public SocketGroup(Image sheet, string socketGroup) {
        InitializeComponent();
        Height = 40;
        foreach(var c in socketGroup) {
            var color = 0;
            switch(c) {
                case 'r':
                case 'R':
                    color = 1;
                    break;
                case 'g':
                case 'G':
                    color = 2;
                    break;
                case 'b':
                case 'B':
                    color = 3;
                    break;
            }

            _ = new Socket(sheet, color) {
                Parent = this
            };
        }
    }

    public SocketGroup(IContainer container) {
        container.Add(this);

        InitializeComponent();
    }
}
