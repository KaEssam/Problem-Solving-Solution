/**
 * @param {number} x
 * @return {number}
 */
var sumOfTheDigitsOfHarshadNumber = function(x) {
    let digitSum = 0;
    let temp = x;
    while (temp > 0) {
        digitSum += temp % 10;
        temp = Math.floor(temp / 10);
    }
    if (x % digitSum === 0) {
        return digitSum;
    }
    return -1;
};