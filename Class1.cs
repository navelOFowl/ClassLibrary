using System;

namespace ClassLibrary
{
    public class Tools
    {
        public static int Discount(int count, int totalCost)
        {
            float price = 0;
            if (count >= 3 && count < 5)
            {
                price /= totalCost * 0.95F;
            }
            else if (count >= 5 && count < 10)
            {
                price /= totalCost * 0.90F;
            }
            else if (count >= 10 && count < 5)
            {
                price /= totalCost * 0.85F;
            }
            int priceWithDis = (int)Math.Floor(price);
            return priceWithDis;
        }
    }
}
