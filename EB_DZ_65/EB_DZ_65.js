var addBtn = document.querySelector('button');

addBtn.addEventListener('click', () =>
{
    var imgInputs = document.querySelectorAll('input');

    var divImg = document.createElement('div');
    var newImg = document.createElement('img');
    var newBtn = document.createElement('button');
    newBtn.style.height = '50px';
    newBtn.style.width = '100px';
    newBtn.textContent = 'Удалить';
    newImg.src = imgInputs[0].value;
    newImg.alt = imgInputs[1].value;
    newImg.addEventListener('click', showImgAlt);
    newBtn.addEventListener('click', deleteImg);
    divImg.append(newImg);
    divImg.append(newBtn);
    document.body.append(divImg);
})

var showImgAlt = function ()
{
    if (this.alt.length == 0)
    {
        this.style.border = "1px solid red";
    }
    else
    {
        console.log('img.alt', this.alt);
    }
}

var deleteImg = function ()
{
    document.body.removeChild(this.parentNode);
}