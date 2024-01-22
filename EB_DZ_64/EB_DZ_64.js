var productsArray = [
    {
      name: 'Яблоко',
      price: 1.00,
      quantity: 50
    },
    {
      name: 'Банан',
      price: 0.75,
      quantity: 30
    },
    {
      name: 'Апельсин',
      price: 1.25,
      quantity: 40
    }
  ];

function productsWrapper(productsArray)
{
    var productsWrapper = document.createElement('ul');
    productsWrapper.classList.add('ul-products');
    for (let i = 0; i < productsArray.length; i++)
    {
        var product = productsArray[i];
        var fields = Object.keys(productsArray[i]);
        var square = document.createElement('ul');
        square.classList.add('ul-product');
        for (const field of fields) {
            var itemName = document.createElement('li');
            itemName.append(field, ': ', product[field])
            square.append(itemName);
        }
        productsWrapper.append(square);
    }
    document.body.append(productsWrapper);
}

productsWrapper(productsArray);