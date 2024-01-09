//Задачка номер 1
const products =
[
  { name: "Футболка", price: 20 },
  { name: "Шорты", price: 25 },
  { name: "Носки", price: 8 },
  { name: "Платье", price: 50 }
];

var sum = 0;
for (let product of products)
{
    sum += product['price'];
}
console.log('sum', sum);

//Задачка номер 2
var expensiveProducts = [];
var expensiveProducts = products.filter((product) => product.price >= 20);
console.log('expensive products' ,expensiveProducts);

//Задачка номер 3
const purchasedProductsIds = [1, 3, 4];
function sumOfPurchased(products, purchasedProductsIds)
{
    var purchasedSum = 0;
    for (let id of purchasedProductsIds)
    {
        purchasedSum += products[id-1]['price'];
    }
    console.log('purchasedSum', purchasedSum);
}
sumOfPurchased(products, purchasedProductsIds);