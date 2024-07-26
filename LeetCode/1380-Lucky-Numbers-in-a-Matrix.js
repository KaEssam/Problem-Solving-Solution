/**
 * @param {number[][]} matrix
 * @return {number[]}
 */
var luckyNumbers  = function(matrix) {
    for(let i = 0;i < matrix.length;i++) {
        let min = Math.min(...matrix[i]),
            idx = matrix[i].indexOf(min);

        if(matrix.every(arr => arr[idx] <= min)) return [min];
    }

    return [];
};