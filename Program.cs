using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> company= new Dictionary<string, string>();
            company.Add("RT", "Rooster Teeth");
            company.Add("AE", "American Eagle");
            company.Add("GM", "General Motors");

            List<(string ticker, int shares, double price)> sales= new List<(string, int, double)>();

            sales.Add((ticker:"RT", shares:230, price: 15.78));
            sales.Add((ticker:"RT", shares:120, price: 9.75));
            sales.Add((ticker:"RT", shares:80, price: 7.89));

            sales.Add((ticker: "AE", shares: 150, price: 5.12));
            sales.Add((ticker: "AE", shares: 60, price: 8.23));
            sales.Add((ticker: "AE", shares: 190, price: 12.98));

            sales.Add((ticker: "GM", shares: 120, price: 14.98));
            sales.Add((ticker: "GM", shares: 98, price: 11.23));
            sales.Add((ticker: "GM", shares: 100, price: 7.01));




            Dictionary<string, double> newSales= new Dictionary<string, double>();

            foreach((string ticker, int shares, double price) x in sales){
                if(company.ContainsKey("ticker")){
                    if(newSales.ContainsKey(company[x.ticker])){
                        newSales[company[x.ticker]]+= x.shares * x.price;
                    }else {
                        newSales.Add(company[x.ticker], x.shares * x.price);
                    }
                }
            }
                foreach(KeyValuePair<string,double> y in newSales){
                    Console.WriteLine(y);
                }

        }
    }
}

