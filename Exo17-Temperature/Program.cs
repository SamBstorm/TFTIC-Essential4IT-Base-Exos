using Exo17_Temperature;

Celsius celsius_gosselies;
celsius_gosselies.temperature = 15;

Fahrenheit fahrenheit_gosselies = celsius_gosselies.Convert();

Fahrenheit fahrenheit_newYork;
fahrenheit_newYork.temperature = 64;

Celsius celsius_newYork = fahrenheit_newYork.Convert();

Console.WriteLine($"A Gosselies il fait : {celsius_gosselies.temperature}° C ou {fahrenheit_gosselies.temperature}° F");
Console.WriteLine($"A NewYork il fait : {celsius_newYork.temperature}° C ou {fahrenheit_newYork.temperature}° F");
