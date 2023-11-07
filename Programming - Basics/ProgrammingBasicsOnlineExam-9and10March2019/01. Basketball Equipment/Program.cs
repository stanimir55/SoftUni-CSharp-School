int yearFee = int.Parse(Console.ReadLine());

double basketballShoes = yearFee - yearFee * 0.40;
double basketballTeam = basketballShoes - basketballShoes * 0.20;
double basketballBall = basketballTeam / 4;
double basketballAccessories = basketballBall / 5;

double price = yearFee + basketballShoes + basketballTeam + basketballBall + basketballAccessories;

Console.WriteLine($"{price:F2}");
