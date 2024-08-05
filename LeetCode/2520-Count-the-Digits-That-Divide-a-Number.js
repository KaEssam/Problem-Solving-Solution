/**
 * @param {number} num
 * @return {number}
 */
var countDigits = function(num) {
    let count = 0 ;
    const n = num;
    
    while(num > 1){
        if(n % (num % 10) === 0) count++
        num = Math.floor(num / 10)
    }
    
    if(num === 1) count++
    
    return count
};