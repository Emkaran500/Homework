function ObjCtor()
{
    this.__proto__ = Array.prototype;
}

var obj = new ObjCtor();
obj.push(100);
obj.push('asdfa');
console.log('obj', obj);