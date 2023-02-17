using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet_store {
    internal class Duck : IPet {
        public string Speak() {
            return "Quack! Quack!";
        }
        public void GetOutOfTheRoad() {

        }
        public void DontPoopOnYourOwner() {

        }
        public string Name { get; set; }

    }
}
