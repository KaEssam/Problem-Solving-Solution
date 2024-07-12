/**
 * @param {string[]} words
 * @return {string[]}
 */
var commonChars = function(words) {
    let result = [];
    if (words.length === 0) return result;

    let minFreq = new Array(26).fill(Infinity);

    for (const word of words) {
        let freq = new Array(26).fill(0);
        for (const c of word) {
            freq[c.charCodeAt(0) - 'a'.charCodeAt(0)]++;
        }
        for (let i = 0; i < 26; i++) {
            minFreq[i] = Math.min(minFreq[i], freq[i]);
        }
    }

    for (let i = 0; i < 26; i++) {
        while (minFreq[i] > 0) {
            result.push(String.fromCharCode(i + 'a'.charCodeAt(0)));
            minFreq[i]--;
        }
    }

    return result;
};