

using Singleton;

var database1 = DatabaseRepository.Instance;
var database2 = DatabaseRepository.Instance;

Console.WriteLine($"Are the instances equal? {database1 == database2}");

// Here we create two instances of the DatabaseRepository
// class using the Instance property.
// Because the Instance property returns the same object every time
// it is called, the two instances should be equal.