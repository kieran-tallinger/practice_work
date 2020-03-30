function isRepdigit(num){
    const str = String(num)
    if (str.charAt(0) === '-') {
        return false
    } else if (str.charAt(0) === '0') {
        return true;
    } else {
        let counter = 0 
        for (let i = 0; i < str.length; i++){
            if(str.charAt(i) === str.charAt(i + 1)) {
                counter++;
            }
        }
        if (counter === str.length -1) {
            return true;
        } else {
            return false;
        };
    };
};