var showImgAlt = function ()
{
    
}

var html = document.querySelector('html');

html.addEventListener('click', (e) =>
{
    var el = e.target;
    if (el.tagName == 'BUTTON')
    {
        if (el.parentNode == document.body)
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
            divImg.append(newImg);
            divImg.append(newBtn);
            document.body.append(divImg);
        }
        else
        {
            document.body.removeChild(el.parentNode);
        }
    }
    else if (el.tagName == 'IMG')
    {
        if (el.alt.length == 0)
        {
            el.style.border = "1px solid red";
        }
        else
        {
            console.log('img.alt', el.alt);
        }
    }
})