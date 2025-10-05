using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeLeveler;
public class Step {

    public string? Passives;
    public string? Regex;
    public Bitmap? PassiveTree;
    public string[]? Links;
    public required string[] Steps;

    public void Init(string imagesDir) {
        if(Passives != null) {
            PassiveTree = new Bitmap(Image.FromFile(Path.Combine(imagesDir, Passives)));
        }
    }

}
