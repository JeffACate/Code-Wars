'use strict';

const TestRunner = require('./TestRunner');

function sumIntervals(intervals) {
  //TODO

  return '';
}

const runner = new TestRunner.TestRunner();
runner.runArrTests(
  [
    {
      actual: [
        [1, 4],
        [7, 10],
        [3, 5],
      ],
      expected: 4,
    },
    {
      actual: [
        [1, 5],
        [6, 10],
      ],
      expected: 8,
    },
    {
      actual: [-1e9, 1e9],
      expected: 2e9
    },
  ],
  sumIntervals
);
