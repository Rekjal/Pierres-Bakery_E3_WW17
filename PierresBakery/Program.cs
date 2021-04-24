using PierresBakery.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      try 
      {
        int breadCount;
        int pastryCount;
        int pastryUnitCost;
        Console.WriteLine("################# Welcome to Pierre's Bakery #################");
        Console.WriteLine("#                           Menu                             #");
        Console.WriteLine("# 1. Bread   : Buy 2, get 1 free. A single loaf costs $5     #");
        Console.WriteLine("# 2. Pastry  : Buy 1 for $2 or 3 for $5                      #");
        Console.WriteLine("##############################################################");

        Console.WriteLine("Enter Bread Qty: ");
        bool parseSuccessBread = int.TryParse(Console.ReadLine(), out breadCount);
        Console.WriteLine("Enter Pastry Qty: ");
        bool parseSuccessPastry = int.TryParse(Console.ReadLine(), out pastryCount);

        while((!parseSuccessBread) || (breadCount < 0) || (!parseSuccessPastry) || (pastryCount < 0)  || (breadCount >25) || (pastryCount > 25)) //ensure qty entered is int and is 0 or greater & less than 25
        {
          Console.WriteLine("INVALID. Enter a valid Quantity else enter Q to Exit or hit ENTER to restart");
          if (Console.ReadLine() == "Q")
          {
            System.Environment.Exit(1);
          }
          else
          {
            Main();
          }
        }

        Bread bread = new Bread(breadCount);
        Pastry pastry = new Pastry(pastryCount);

        Console.WriteLine($"{"\n"}THANK YOU for your order!!!! See receipt below ....{"\n"}{"\n"}");
        Console.WriteLine("###################### Pierre's Bakery #######################");
        Console.WriteLine($"Invoice # {Pastry.UnixTimeNow()}");
        Console.WriteLine($"Date: {DateTime.Now.ToString("M/d/yyyy")}");
        Console.WriteLine($"Time: {DateTime.Now.ToString("h:mm:ss tt")}{"\n"}");
        Console.WriteLine("==============================================================");
        Console.WriteLine($"ITEM{"\t"}QTY{"\t"}DESC{"\t"}{"\t"}{"\t"}{"\t"}RATE{"\t"}AMOUNT");
        Console.WriteLine($"Bread{"\t"}{breadCount}{"\t"}Total Qty is {bread.FindTotalQuantity()}{"\t"}{"\t"}{"\t"}${bread.BreadUnitCost}{"\t"}${bread.FindTotalCost()}");
        if(pastryCount > 2)
        {
          pastryUnitCost = pastry.PastryCostForThree;
        }
        else
        {
          pastryUnitCost = pastry.PastryUnitCost;
        }
        Console.WriteLine($"Pastry{"\t"}{pastryCount}{"\t"}Buy 1 for $2 or 3 for $5{"\t"}${pastryUnitCost}{"\t"}${pastry.FindTotalCost()}");
        Console.WriteLine("==============================================================");
        Console.WriteLine($"TOTAL{"\t"}{"\t"}{"\t"}{"\t"}{"\t"}{"\t"}{"\t"}${bread.FindTotalCost() + pastry.FindTotalCost()}");

        System.Environment.Exit(1);
      }
      catch (Exception ex)
      {
        Console.WriteLine("Message = {0}", ex.Message);
        Console.WriteLine("Source = {0}", ex.Source);
        Console.WriteLine("StackTrace = {0}", ex.StackTrace);
        Console.WriteLine("TargetSite = {0}", ex.TargetSite);
      }
    }
  }
}