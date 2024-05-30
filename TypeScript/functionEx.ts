function add(a=10,b=12){
    console.log("Addition is "+(a+b));
}
add();

function strnum(a:string="Apple",b:number=12){
    console.log("Adding String and Number " + (a+b));
}
strnum();

console.log(typeof(strnum));