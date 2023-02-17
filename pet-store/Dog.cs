using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet_store; 
internal class Dog : IPet {

    public string Speak() {
        return "says Bark!";
    }
    public void Sit() {


    }
    public void Fetch() {


    }
    public string Name { get; set; }
    public int Weight { get; set; }
}
