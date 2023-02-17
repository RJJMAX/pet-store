using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet_store; 
internal class Cat : IPet {
    public string Speak() {
        return "Meow!";
    }
    public void DontPeeOnTheRug() {

    }
    public void DontScratchTheFurniture() {

    }
    public void CleanYourOwnLitterBox() {

    }
    public string Name { get; set; } = string.Empty;
    public int Weight { get; set; }
}
