using System;
using PierresBakery.Models;
using System.Collections.Generic;

namespace PierresBakery
{
    public class Program
    {
        public static void Main()
        {
            try
            {

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
