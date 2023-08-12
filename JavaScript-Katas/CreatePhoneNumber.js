"use strict"
function createPhoneNumber(numbers){
    return "";
}

function runTests(tests) {
    tests.forEach((test) => {
        console.log(`${test.actual} | ${test.expected} ${assert(createPhoneNumber(test.actual), test.expected)}`);
    });
}

function assert(actual, expected) { 
    return actual === expected;
} 

runTests(
    [
        {
            actual:  [1, 2, 3, 4, 5, 6, 7, 8, 9, 0],
            expected: "(123) 456-7890"
        },
        {
            actual: [1, 1, 1, 1, 1, 1, 1, 1, 1, 1], 
            expected: "(111) 111-1111"
        },
        {
            actual: [1, 2, 3, 4, 5, 6, 7, 8, 9, 0], 
            expected: "(123) 456-7890"
        }
    ]
);