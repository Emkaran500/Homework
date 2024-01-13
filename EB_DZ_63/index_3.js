//Задачка номер 3
const products2 = [
  { id: 1, name: "Футболка", price: 20 },
  { id: 2, name: "Шорты", price: 25 },
  { id: 3, name: "Носки", price: 8 },
  { id: 4, name: "Платье", price: 50 }
];
const purchasedProductsIds = [1, 3, 4];
function sumOfPurchased(products, purchasedProductsIds)
{
    var purchasedSum = 0;

    for (let id of purchasedProductsIds)
    {
        purchasedSum += products.find((product) => product.id == id).price;
    }
    
    console.log('purchasedSum', purchasedSum);
}
sumOfPurchased(products2, purchasedProductsIds);