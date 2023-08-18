'use strict';

const TestRunner = require('./TestRunner');

function sumIntervals(intervals) {
  //TODO
  intervals.sort((a, b) => {
    if (a[1] < b[1]) {
      return -1;
    } else if (a[1] < b[1]) {
      return 1;
    }
    return 0;
  });
  console.table(intervals);
  var min = 0;
  var max = 0;

  for (let i = 0; i < intervals.length - 1; i++) {
    const current = intervals[i];
    const next = intervals[i+1];
    let first = 0;
    let last = 1;
    if (isNotSequential(current, next)){
      min = (min === 0 || current[0] < min) ? current[0] : min;
      max = next[1] > max ? next[1] : max;
      console.log(`${min} ${max}`);
    } 
  }
  console.log(`${(max > 0 ?  max - min : 0)}`);
  return max > 0 ?  max - min : 0;
}

function isNotSequential(cur, next){
  let most = cur[1]+1;
  return next[0] <= most ? true : false;
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
      expected: 2e9,
    },
  ],
  sumIntervals
);
