/**
 * @param {string[]} emails
 * @return {number}
 */
var numUniqueEmails = function(emails) {
    let uniqueEmails = new Set();  
    
    for (let email of emails) {
        
        let [local, domain] = email.split('@');  

        local = local.replace(/\./g, '');  

        let plusIndex = local.indexOf('+');  

            if (plusIndex !== -1) {
                
                local = local.substring(0, plusIndex); 
            }
            
            uniqueEmails.add(local + '@' + domain); 
    }
    
    return uniqueEmails.size; 
  
};