const fsAsync = require('fs').promises
const DIRNAME = './data/'
const FILENAME = 'chat.json'
let idCount = 0

const createChatIfNotExists = async () =>
{
    try
    {
        if ((await fsAsync.readdir(DIRNAME)).includes(FILENAME))
        {
            console.log(await fsAsync.readFile(DIRNAME + FILENAME, 'utf-8'))
        }
        else
        {
            await fsAsync.writeFile(DIRNAME + FILENAME, '[]')
        }
    }
    catch (err)
    {
        console.log('Couldn\'t reach file!\n' + err)
    }
}



const fromUserToUser = async (message, fromUser, toUser) =>
{
    try
    {
        let date_ob = new Date();
        let date = ("0" + date_ob.getDate()).slice(-2);
        let month = ("0" + (date_ob.getMonth() + 1)).slice(-2);
        let year = date_ob.getFullYear();
        let hours = date_ob.getHours();
        let minutes = date_ob.getMinutes();
        let seconds = date_ob.getSeconds();
        let dateNow = year + "-" + month + "-" + date + " " + hours + ":" + minutes + ":" + seconds;

        let messageObj = 
        {
            id: idCount,
            message: message,
            from: fromUser,
            to: toUser,
            date: dateNow
        }

        let chat = await fsAsync.readFile(DIRNAME + FILENAME, 'utf-8')

        let chatJson = JSON.parse(chat)
        chatJson.push(messageObj)
        let chatString = JSON.stringify(chatJson)
        await fsAsync.writeFile(DIRNAME + FILENAME, chatString, { flag: 'w' })

        idCount += 1
    }
    catch (err)
    {
        console.log('Something went wrong during addition!\n' + err)
    }
}

const deleteMessage = async (id) =>
{
    try
    {
        let chat = await fsAsync.readFile(DIRNAME + FILENAME, 'utf-8')

        let chatJson = JSON.parse(chat)
        let deletingObjIndex = chatJson.findIndex(el => el.id == id)
        console.log('deletingObj index: %d', deletingObjIndex)
        if (deletingObjIndex != -1)
        {
            chatJson.splice(deletingObjIndex, 1)
            let chatString = JSON.stringify(chatJson)
            await fsAsync.writeFile(DIRNAME + FILENAME, chatString, { flag: 'w' })
        }
    }
    catch (err)
    {
        console.log('Something went wrong during deletion!\n' + err)
    }
}

const editMessage = async (id, message) =>
{
    try
    {
        let chat = await fsAsync.readFile(DIRNAME + FILENAME, 'utf-8')

        let chatJson = JSON.parse(chat)
        let editObjIndex = chatJson.findIndex(el => el.id == id)
        let editObj = chatJson.find(el => el.id == id)
        editObj.message = message
        console.log(editObj)
        console.log('editObj index: %d', editObjIndex)
        chatJson.splice(editObjIndex, 1, editObj)
        console.log(chatJson)
        let chatString = JSON.stringify(chatJson)
        await fsAsync.writeFile(DIRNAME + FILENAME, chatString, { flag: 'w' })
    }
    catch (err)
    {
        console.log('Something went wrong during edit!\n' + err)
    }
}

createChatIfNotExists()

// Добавление элемента в чат
setTimeout(() => {
    fromUserToUser('text', 'me', 'him')
}, 1000);

// Удаление элемента из чата
setTimeout(() => {
    deleteMessage(0)
}, 6000);

//Редактирование элемента в чате
setTimeout(() => {
    editMessage(0, 'new text')
}, 3000);