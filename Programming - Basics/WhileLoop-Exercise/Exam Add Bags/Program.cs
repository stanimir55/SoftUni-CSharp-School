double priceBaggageOver20Kg = double.Parse(Console.ReadLine());
double baggageKilograms = double.Parse(Console.ReadLine());
int daysTrip = int.Parse(Console.ReadLine());
int bagsNum = int.Parse(Console.ReadLine());

double finalPrice = 0;
double taxForBaggage = 0;
double increase = 0;
if (baggageKilograms < 10)
{
    taxForBaggage = priceBaggageOver20Kg * 0.20;
    if (daysTrip < 7)
    {
        increase = taxForBaggage + taxForBaggage * 0.40;
        finalPrice = increase * bagsNum;
    }
    else if (daysTrip <= 30)
    {
        increase = taxForBaggage + taxForBaggage * 0.15;
        finalPrice = increase * bagsNum;
    }
    else if (daysTrip > 30)
    {
        increase = taxForBaggage + taxForBaggage * 0.10;
        finalPrice = increase * bagsNum;
    }

}
else if (baggageKilograms <= 20)
{
    taxForBaggage = priceBaggageOver20Kg * 0.50;
    if (daysTrip < 7)
    {
        increase = taxForBaggage + taxForBaggage * 0.40;
        finalPrice = increase * bagsNum;
    }
    else if (daysTrip <= 30)
    {
        increase = taxForBaggage + taxForBaggage * 0.15;
        finalPrice = increase * bagsNum;
    }
    else if (daysTrip > 30)
    {
        increase = taxForBaggage + taxForBaggage * 0.10;
        finalPrice = increase * bagsNum;
    }

}
else if (baggageKilograms > 20)
{
    taxForBaggage = priceBaggageOver20Kg;
    if (daysTrip < 7)
    {
        increase = taxForBaggage + taxForBaggage * 0.40;
        finalPrice = increase * bagsNum;
    }
    else if (daysTrip <= 30)
    {
        increase = taxForBaggage + taxForBaggage * 0.15;
        finalPrice = increase * bagsNum;
    }
    else if (daysTrip > 30)
    {
        increase = taxForBaggage + taxForBaggage * 0.10;
        finalPrice = increase * bagsNum;
    }
}

finalPrice = increase * bagsNum;
Console.WriteLine($"The total price of bags is: {finalPrice:F2} lv. ");