/**
 * @param {string} s
 * @return {number}
 */
var longestPalindrome = function(s) {
    const obj = {}
    let sum = 0;
    
    for(let i = 0; i < s.length; i++){
        const ch = s[i]
        if(!obj[ch]){
            obj[ch] = 1;
        }else{
            obj[ch] = 0;
            sum += 2;
        }
    }
    
    if( sum < s.length ){
        return sum + 1;
    }else{
        return sum;
    }
};