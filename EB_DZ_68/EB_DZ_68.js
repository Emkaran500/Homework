const btn = document.forms.registration.sendBtn;
const genders = document.forms.registration.gender;
const maleGender = genders[0];
const armyCheckBox = document.forms.registration.army;
const ageInput = document.forms.registration.age;
const cigarettesCheckBox = document.forms.registration.cigarettes;

genders.forEach(gender =>
{
    gender.addEventListener('click', () => openNextNode(maleGender.checked, '.div-army'))
});

armyCheckBox.addEventListener('click', () => openNextNode(armyCheckBox.checked, '.input-select'));

ageInput.addEventListener('input', (e) => 
{
    checkForLetters(e.data, e);
    age = Number(e.target.value);
    const correctAge = (age >= 14 && age <= 100);
    showError(correctAge, e.target, 'Неправильный возраст!');
    const matureAge = age >= 18;
    openNextNode((matureAge && correctAge), '.div-cigarettes');
});

cigarettesCheckBox.addEventListener('click', (e) =>
{
    const cigarettesChecked = e.target.checked;
    openNextNode(cigarettesChecked, '.input-text.input-cigarettes');
})

const checkInputCorrectness = (str) =>
{
    let counter = 0;
    let errorDescs = [];
    const minLength = 5;
    const maxLength = 8;

    if (str.length < minLength || str.length > maxLength)
    {
        errorDescs.push("Неправильная длина записи.");
        counter++;
    }
    if (str.split(' ').length > 1)
    {
        errorDescs.push("Нельзя использовать пробелы.");
        counter++;
    }
    if (/\d/.test(str))
    {
        errorDescs.push("Нельзя использовать цифры.");
        counter++;
    }

    if (counter > 0)
    {
        return [false, errorDescs];
    }
    else
    {
        return [true, errorDescs];
    }
}

const checkEmail = (email) =>
{
    return /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|.(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
    .test(email.toLowerCase());
}

const showError = (flag, input, errors = 'Неправильные данные.') =>
{
    if (input.nextElementSibling != null)
    {
        if (input.nextElementSibling.tagName == 'P')
        {
            input.parentNode.removeChild(input.nextElementSibling);
        }
    }

    if (flag == false)
    {
        const prgh = document.createElement('p');
        prgh.style.color = 'red';
        prgh.style.margin = '0px'
        prgh.style.marginLeft = '10px';
        
        if (typeof(errors) != "string")
        {
            errors.forEach(error =>
            {
                prgh.textContent += error;
            });
        }
        else
        {
            prgh.textContent = errors;
        }
        input.after(prgh);
        input.classList.add('error');
    }
    else
    {
        input.classList.remove('error');
    }
}

const checkRadios = (radios) =>
{
    return radios.includes(true);
}

const openNextNode = (flag, inputName) =>
{
    const node = document.querySelector(inputName);
    if (flag)
    {
        node.style.display = 'block';
    }
    else
    {
        node.style.display = 'none';
    }
}

const checkForLetters = (str, e) =>
{
    if (/^[A-Za-z]+$/.test(str) == true && str != null)
    {
        e.target.value = e.target.value.substring(0, e.target.value.length - 1);
    }
}

btn.addEventListener('click', (e) =>
{
    const nameInput = document.forms.registration.firstName
    const name = nameInput.value;
    const surnameInput = document.forms.registration.lastName
    const surname = surnameInput.value;
    const emailInput = document.forms.registration.email
    const email = emailInput.value;
    const gendersInput = document.forms.registration.gender;
    const lastGender = gendersInput.length - 1;
    const maleCheck = gendersInput[0].checked;
    const femaleCheck = gendersInput[1].checked;
    
    let check = checkInputCorrectness(name);
    showError(check[0], nameInput, check[1]);
    check = checkInputCorrectness(surname);
    showError(check[0], surnameInput, check[1]);
    showError(checkEmail(email), emailInput);
    showError(checkRadios([maleCheck, femaleCheck]), gendersInput[lastGender]);
    
    if (document.querySelector('.error') != null)
    {
        e.preventDefault();
    }
});