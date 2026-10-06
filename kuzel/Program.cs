decimal r = NacitajCislo("Zadaj polomer r ");
decimal v = NacitajCislo("Zadaj vysku v ");
decimal s = NacitajCislo("Zadaj stranu s ");

decimal objem = VypocitajObjem(r, v);
decimal povrch = VypocitajPovrch(r, s);

Console.WriteLine("Objem kužeľa je: " + objem);
Console.WriteLine("Povrch kužeľa je: " + povrch);


decimal NacitajCislo(string text)
{
    Console.WriteLine(text + ":");
    string cislo = Console.ReadLine();
    return decimal.Parse(cislo);

}

decimal VypocitajObjem(decimal polomer, decimal vyska)
{ 
    return (3.14m * polomer * polomer * vyska) / 3m;
}

decimal VypocitajPovrch(decimal polomer, decimal strana)
{
    return (3.14m * polomer * polomer) + (3.14m * polomer * strana); 
}
