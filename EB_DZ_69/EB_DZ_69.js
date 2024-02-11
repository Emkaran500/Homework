const body = document.body;

function addInfo(objData, parentSquare)
{
    if (objData.__proto__ == Array.prototype)
    {
        objData.forEach(objCredential => {
            const userSquare = document.createElement('ul');
            userSquare.classList.add('ul-square');
            const credentials = Object.keys(objCredential);
            credentials.forEach(credential => {
                if (typeof(objCredential[credential]) == 'object')
                {
                    const wrapperSquare = document.createElement('li');
                    wrapperSquare.textContent = credential;
                    const currentSquare = document.createElement('ul');
                    currentSquare.classList.add('ul-square');
                    addInfo(objCredential[credential], currentSquare);
                    wrapperSquare.appendChild(currentSquare);
                    userSquare.appendChild(wrapperSquare);
                    parentSquare.appendChild(userSquare);
                }
                else
                {
                    const credentialData = document.createElement('li');
                    credentialData.textContent = credential + ": " + objCredential[credential];
                    userSquare.appendChild(credentialData);
                    parentSquare.appendChild(userSquare);
                }
            })
        });
        body.appendChild(parentSquare);
    }
    else
    {
        const subFields = Object.keys(objData);
        const subCredentials = document.createElement('ul');
        subCredentials.classList.add('ul-square');
        subFields.forEach(subField => {
            if (objData[subField].__proto__ != Object.prototype)
            {
                const subData = document.createElement('li');
                subData.textContent = subField + ": " + objData[subField];
                subCredentials.appendChild(subData);
            }
            else
            {
                const subData = document.createElement('li');
                subData.textContent = subField;
                const currentSquare = document.createElement('ul');
                currentSquare.classList.add('ul-square');
                addInfo(objData[subField], subCredentials);
                subData.appendChild(currentSquare);
            }
        });
        parentSquare.appendChild(subCredentials);
    }
}

function addUsers()
{
    fetch('https://jsonplaceholder.typicode.com/users').then(response => response.json()).then(usersArr => 
    {
        const users = document.createElement('ul');
        addInfo(usersArr, users);
    });
}

addUsers();