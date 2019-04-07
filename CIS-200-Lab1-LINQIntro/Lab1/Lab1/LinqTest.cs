/*
 * Lab 1
 * CIS 200-76
 * Due: 09/20/17
 * Grading Id: D4199
 *
 * A simple console app to display information based on
 * querying invoices with LINQ.
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    public class LinqTest
    {
        public static void Main(string[] args)
        {
            // initialize array of invoices
            Invoice[] invoices = { 
                new Invoice( 83, "Electric sander", 7, 57.98M ), 
                new Invoice( 24, "Power saw", 18, 99.99M ), 
                new Invoice( 7, "Sledge hammer", 11, 21.5M ), 
                new Invoice( 77, "Hammer", 76, 11.99M ), 
                new Invoice( 39, "Lawn mower", 3, 79.5M ), 
                new Invoice( 68, "Screwdriver", 106, 6.99M ), 
                new Invoice( 56, "Jig saw", 21, 11M ), 
                new Invoice( 3, "Wrench", 34, 7.5M ) };

            // Display original array
            Console.WriteLine("Original Invoice Data\n");
            Console.WriteLine("P.Num Part Description     Quant Price"); // Column Headers
            Console.WriteLine("----- -------------------- ----- ------");

            foreach (Invoice inv in invoices)
                Console.WriteLine(inv);

            //Begin my code

            //Part A -> Sort by PartDescription and output
            Console.WriteLine("---- Part A ----");
            var invByPart = from inv in invoices orderby inv.PartDescription select inv;
            foreach (Invoice inv in invByPart)
            {
                Console.WriteLine(inv);
            }
                
            
            //Part B -> Sort by Price and output
            Console.WriteLine("---- Part B ----");
            var invByPrice = from inv in invoices orderby inv.Price select inv;
            foreach (Invoice inv in invByPrice)
            {
                Console.WriteLine(inv);
            }
                

            //Part C -> Select PartDescription and Qty order by Qty and output
            Console.WriteLine("---- Part C ----");
            var invDescQty = from inv in invoices orderby inv.Quantity select new { inv.PartDescription, inv.Quantity };
            Console.WriteLine("Qty   Part Description"); // Column Headers
            Console.WriteLine("----- --------------------");
            foreach (var obj in invDescQty)
            {
                Console.WriteLine($"{obj.Quantity,-5} {obj.PartDescription,-20}");
            }


            //Part D -> Select PartDescription and Value (Price * Qty) set to InvoiceTotal and order by it, then output
            Console.WriteLine("---- Part D ----");
            var invD = from inv in invoices let total = inv.Price * inv.Quantity
                       orderby total select new { inv.PartDescription, inv.PartNumber, inv.Price, inv.Quantity, InvoiceTotal = total};
            Console.WriteLine("P.Num Part Description     Quant Price     Total"); // Column Headers
            Console.WriteLine("----- -------------------- ----- ------    -----");
            foreach (var obj in invD)
            {
                Console.WriteLine($"{obj.PartNumber,-5} {obj.PartDescription,-20} {obj.Quantity,-5} {obj.Price,6:C} {obj.InvoiceTotal,10:C}");
            }

            
            //Part E -> Use Part D invD to select where Total is within $200-$500
            Console.WriteLine("---- Part E ----");
            var invDOrdered = from inv in invD where inv.InvoiceTotal >= 200 && inv.InvoiceTotal <= 500 select inv;
            foreach (var obj in invDOrdered)
            {
                Console.WriteLine($"{obj.PartNumber,-5} {obj.PartDescription,-20} {obj.Quantity,-5} {obj.Price,6:C} {obj.InvoiceTotal,10:C}");
            }
        }
        
    }
}
