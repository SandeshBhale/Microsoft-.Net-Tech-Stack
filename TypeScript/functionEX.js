function add(a, b) {
    if (a === void 0) { a = 10; }
    if (b === void 0) { b = 12; }
    console.log("Addition is " + (a + b));
}
add();
function strnum(a, b) {
    if (a === void 0) { a = "Apple"; }
    if (b === void 0) { b = 12; }
    console.log("Adding String and Number " + (a + b));
}
strnum();
console.log(typeof (strnum));
