using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet_store; 
internal class Cow : IPet {
    public string Speak() {
        return "says Moooo!";
    }
    public void MilkYourself() {

    }
    public void GetYourOwnHay() {

    }
    public string Name { get; set; }
    public int Weight { get; set; }
}
