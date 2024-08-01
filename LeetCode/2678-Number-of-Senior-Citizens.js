/**
 * @param {string[]} details
 * @return {number}
 */
var countSeniors = function(details) {
    return details.reduce((count, info) => {
        const tens = info[11];
        const ones = info[12];
        return count + (tens > '6' || (tens === '6' && ones > '0') ? 1 : 0);
    }, 0);
};