

using pet_store;

IPet[] pets = new IPet[] {
    new Dog() {Name = "Fido", Weight = 30},
    new Cat() {Name = "Garfield", Weight = 12},
    new Duck() {Name = "Lunch"},
    new Cow() {Name = "Dinner", Weight = 128},
    new Pigmy_goat() {Name = "Arthur"}
};


foreach (var pet in pets) {
    Console.WriteLine($"{pet.Name} says {pet.Speak}");
    
}