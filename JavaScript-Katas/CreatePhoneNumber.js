"use strict"
const TestRunner = require('./TestRunner')

function createPhoneNumber(numbers){
    numbers = numbers.join('');
    return `(${numbers.slice(0, 3)}) ${numbers.slice(3, 6)}-${numbers.slice(7-11)}`;
}

const runner = new TestRunner.TestRunner();
runner.runTests(
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
    ],
    createPhoneNumber
);