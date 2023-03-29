﻿namespace Creational.AbstractFactory.CreditCardFactory;
class TitaniumCard : ICreditCardTerms
{
    public int GetAnnualCost()
    {
        return 250;
    }

    public int GetLimit()
    {
        return 15000;
    }

    public string GetCardType()
    {
        return "Titanium Card";
    }
}

