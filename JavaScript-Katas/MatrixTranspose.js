'use strict'

const TestRunner = require('./TestRunner')

function transpose(matrix) {
    var columns = matrix[0].length;
    var rows = matrix.length;

    if (columns === 1) return matrix;
    var transform = Array.from(Array(columns), () => new Array(rows));
    for (var i = 0; i < columns; i++){
        for (var j = 0; j < rows; j++){
            transform[i][j] = matrix[j][i];
        }
    }

    return transform;
}

const runner = new TestRunner.TestRunner();
runner.runArrTests(
    [
        {
            actual:  [[1]],
            expected: [[1]]
        },
        {
            actual: [[1,2,3],[4,5,6]], 
            expected: [[1,4],[2,5],[3,6]]
        }
    ],
    transpose
);