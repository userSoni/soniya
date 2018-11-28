// JavaScript source code
//no.3
function Drinks(drink1, drink2) {
    this.drink1 = drink1;
    this.drink2 = drink2;
}

let hotdrink = new Drinks("Coffee");
let colddrink = new Drinks("Cocacola");

console.log(hotdrink.drink1);
console.log(colddrink.drink1);

//no.4

function vehicleType(color, code) {

    const type = { "1": "Car", "2": "Motorbike" };

    return "A " + color + " " + type[code] +".";
}

console.log(vehicleType("blue", 2));

//no.5
console.log(3 === 3);

//no.6
function vehicle(color, modeltype, code) {

    const type = { "1": "new", "2": "used" },
         vtype = { "1": "Car", "2": "Motorbike"};

    return "A " + color + " " + type[modeltype] + " " + vtype[code] + ".";
}

console.log(vehicle("blue ", 2, 1));

//no.7 - no.8
let vehicles = ["motorbikes", "caravans", "bikes", "car", "Buses"];
//vehicles.sort()(serialized alphabet); shift(2, 3);
let thirdEle = vehicles.slice(2, 3);

console.log(vehicles); 
console.log(thirdEle);

//no.9
function vehicle(color, usetype, code) {

    const type = { "1": "new", "2": "used" },
        newtype = { "1": "Car", "2": "Motorbike", "3": "caravan" } ;

    return "A " + color + " " + type[usetype] + " " + newtype[code] + ".";
}

console.log(vehicle("green", 1, 3));

//no.10
//let text = "";https://www.htmlgoodies.com/html5/javascript/getting-fancy-with-the-javascript-for-loop.html
//for (var i=0, len=cars.length, text="You've got "+len+" cars: "; i<len; i++)
let vehiclesList = ["motorbikes", "caravans", "bikes", "car", "buses"];
vehiclesList.sort();
for (var i = 0, len = vehiclesList.length, text = "Amazing Joe's Garage, we service " ; i<len; i++) {
    text += vehiclesList[i] + ", ";
}

console.log(text);

//no-11
let vehiclesL = ["motorbikes", "caravans", "bikes", "car", "buses", "tempu", "truck"];
vehiclesL.sort();
for (var i = 0, len = vehiclesL.length, text = "Amazing Joe's Garage, we service "; i < len; i++) {
    text += vehiclesL[i] + ", ";
}

console.log(text);

//no.12
var emptyObj = {};
console.log(emptyObj.constructor);

//no.13
var obj1 = {
    a: "1",
    b: "this is the letter b",
    c: {
        foo: "what is a foo anyway",
        bar: [1, 2, 3, 4]
    }
};

var obj2 = {
    a: "1",
    b: "this is the letter b",
    c: {
        foo: "what is a foo anyway",
        bar: [1, 2, 3, 4]
    }
};

console.log(obj1 == 'foo');
console.log(obj1 === obj2);
//https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Comparison_Operators
//if (obj == obj2) {
//    console.log(true);
//} else if (obj1 === obj2) {
//    console.log(false);
//} else {
//    console.log("Error");
//}

//step 4: 
//ques: 3
function halfPyramid(height) {
    for (let i = 1; i <= height; i++) {
        let row = '';

    for (let j = 1; j <= i; j++) {
        row += '*';
        }
        console.log(row);
}
}

halfPyramid(6);

//https://js-algorithms.tutorialhorizon.com/2015/10/18/print-half-pyramid/
