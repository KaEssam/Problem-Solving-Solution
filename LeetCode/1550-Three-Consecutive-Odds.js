/**
 * @param {number[]} arr
 * @return {boolean}
 */
var threeConsecutiveOdds = function(arr) {
    let streak = 0;
    for(let i = 0; i < arr.length; i++){
        if(arr[i] % 2 !== 0){
            streak++;
            if(streak === 3){
                return true;
            }
        }else{
            streak = 0;
        }
    }
    return false;
};