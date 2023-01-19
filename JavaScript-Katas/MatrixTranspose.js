console.log('JS Kata');

function transpose(matrix) {
    var columns = matrix[0].length;
    console.log(`rows = ${columns}`);
    var rows = matrix.length;
    console.log(`column = ${rows}`);

    if (columns === 1) return matrix;
    var transform = Array.from(Array(columns), () => new Array(rows));
    for (var i = 0; i < columns; i++){
        for (var j = 0; j < rows; j++){
            transform[i][j] = matrix[j][i];
        }
    }

    return transform;
}

console.log(transpose([[1]]), "equals", [[1]]);
console.log(transpose([[1,2,3],[4,5,6]]), " equals ", [[1,4],[2,5],[3,6]]);