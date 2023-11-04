public static class Basket
{
    public static int basketLength = 0;
    public static Products[] products = new Products[basketLength];
    public static double finalSum = 0;

    public static Products[] AddProduct(Products prod)
    {
        basketLength++;
        Products[] newProducts = new Products[basketLength];
        newProducts[basketLength - 1] = prod;
        finalSum += prod.price;

        for (int i = 0; i < basketLength - 1; i++)
        {
            newProducts[i] = products[i];
        }

        products = newProducts;

        return Basket.products;
    }

    public static Products[] DeleteProduct()
    {
        if (basketLength <= 0)
            return Basket.products;

        basketLength--;
        Products[] newProducts = new Products[basketLength];

        for (int i = 0; i < basketLength; i++)
        {
            newProducts[i] = products[i];
        }

        products = newProducts;

        return Basket.products;
    }
}
