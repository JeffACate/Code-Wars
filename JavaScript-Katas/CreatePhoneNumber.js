"use strict"
function createPhoneNumber(numbers){
    return "";
}

function tests() {
    console.log(assert(createPhoneNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]), "(123) 456-7890"));
    console.log(assert(createPhoneNumber([1, 1, 1, 1, 1, 1, 1, 1, 1, 1]), "(111) 111-1111"));
    console.log(assert(createPhoneNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]), "(123) 456-7890"));
}

function assert(actual, expected) {
    console.log(actual);
    console.log(`${(actual === expected ? "pass" : "fail")}`);
    return actual === expected;
} 

tests();