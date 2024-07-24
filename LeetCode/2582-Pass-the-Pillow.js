/**
 * @param {number} n
 * @param {number} time
 * @return {number}
 */
var passThePillow = function(n, time) {
    let chunks = Math.floor(time / (n - 1));
    return chunks % 2 === 0 ? (time % (n - 1) + 1) : (n - time % (n - 1));
};