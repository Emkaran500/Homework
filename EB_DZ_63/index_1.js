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