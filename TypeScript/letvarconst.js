var a = 12;
var b = 15;
var c = 16;
//Can't Assign it cause c is const
//c=17;
function f() {
    var d = 14;
    console.log(b, d, a);
    var z = 99;
    var x = 69;
}
f();
//We can't print any variable from funcation f
//because of their f() scope only
//console.log(x);
