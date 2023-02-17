using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pet_store {
    internal class Pigmy_goat : IPet {
        public string Speak() {
            return "says Baaaaa!";
        }
        public string Name { get; set; }
    }
}
