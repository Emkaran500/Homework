// Нужно написать чтение файла через async await.
// В случае ошибки вывести информацию об ошибке и 
// сообщить о том что нужно исправить ошибку, в ином 
// случае просто показать данные из файла

const fs = require('fs').promises

const readFunc = async () =>
{
    try
    {
        let data = await fs.readFile('text.txt', 'utf-8')
        console.log(data)
    }
    catch (err)
    {
        console.log("An error has occured! Please use following data to fix the issue:\n" + err)
    }
}

readFunc()