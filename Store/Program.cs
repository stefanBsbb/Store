using Store;
using Store.Attributes;
using Store.Models;
using Store.Models.Abstractions;

public class Program
{
    static void Main(string[] args)
    {
        PrintReceipt(PrepCart());
    }
    public static void PrintReceipt(Cart cart)
    {
        PrepCart();
        double totalDiscount = 0;
        double itemDiscount = 0;
        Console.WriteLine("Date and tiem of purchase:");
        Console.WriteLine(cart.GetPurchaseDate());
        Console.WriteLine("---Products---");
        Console.WriteLine();
        if (cart != null)
        {
            foreach (var item in cart.cart)
            {
                foreach (var prop in item.GetType().GetProperties().Where(p => !p.IsMarkedWith<DoNotIncludeAttribute>()))
                {

                    if (prop.IsMarkedWith<SemiIncludeAttribute>())
                    {
                        switch (prop.Name)
                        {
                            case "Price":
                                Console.Write("$" + prop.GetValue(item) + " x ");
                                break;
                            case "Quantity":
                                Console.Write(prop.GetValue(item) + " = ");
                                break;
                            case "TotalPrice":
                                Console.Write("$" + prop.GetValue(item));
                                break;
                        }
                    }
                    else
                    {
                        Console.Write(prop.GetValue(item) + "  ");
                    }

                }
                if (item.Discount() > 0)
                {
                    double a = Decimal.ToDouble(item.Price);
                    double b = Convert.ToDouble(item.Discount());
                    itemDiscount = item.Quantity * (a * (b / 100));
                    totalDiscount = totalDiscount + itemDiscount;

                    Console.WriteLine();
                    Console.WriteLine("#discount " + item.Discount() + "%  - $" + Math.Round(itemDiscount, 2, MidpointRounding.AwayFromZero));
                }

                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("SUBTOTAL: $" + Math.Round(cart.TotalSum(), 2, MidpointRounding.AwayFromZero));
            Console.WriteLine("DISCOUNT: $" + Math.Round(totalDiscount, 2, MidpointRounding.AwayFromZero));
            decimal totalPriceWithDiscount = cart.TotalSum() - Convert.ToDecimal(totalDiscount);
            Console.WriteLine("TOTAL: $" + Math.Round(totalPriceWithDiscount, 2, MidpointRounding.AwayFromZero));
        }

    }
    public static Cart PrepCart()
    {
        Cart cart = new Cart();
        if (cart != null)
        {
            cart.AddItems();
            EntityTypeCounter counter = cart.cart.Aggregate(
                new EntityTypeCounter(),
                (acc, item) => { item.Accept(acc); return acc; });            
        }
        return cart;
    }
}