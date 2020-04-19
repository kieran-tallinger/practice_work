function changeTypes(arr) {
	return arr.map(elem => {
        if (typeof elem === 'number' && elem%2 === 0){
            return elem + 1;
        } else if (typeof elem === 'string') {
            let tempStr = elem.split('');
            tempStr[0] = tempStr[0].toUpperCase();
            tempStr[tempStr.length] = '!';
            return tempStr.join('');
        } else if (typeof elem === 'boolean') {
            if (elem === true) {
                return false;
            } else {
                return true;
            }
        } else {
            return elem;
        };
    });
}