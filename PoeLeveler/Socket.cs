using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoeLeveler;
public partial class Socket : UserControl {

    private Rectangle RED = new(141, 1, 34, 34);
    private Rectangle GREEN = new(36, 106, 34, 34);
    private Rectangle BLUE = new(106, 1, 34, 34);
    private Rectangle ACTUAL = new(0, 0, 0, 0);

    private Image _sheet;

    /// <param name="color">1 = red, 2 = green, 3 = blue</param>
    public Socket(Image sheet, int color) {
        _sheet = sheet;
        InitializeComponent();
        Size = new Size(34, 34);
        ACTUAL = color == 1 ? RED : color == 2 ? GREEN : color == 3 ? BLUE : ACTUAL;
    }

    protected override void OnPaint(PaintEventArgs e) {
        base.OnPaint(e);
        var srcRect = new Rectangle(0, 0, 34, 34);
        var destRect = ACTUAL;
        e.Graphics.DrawImage(_sheet, srcRect, destRect, GraphicsUnit.Pixel);
        
    }
}
