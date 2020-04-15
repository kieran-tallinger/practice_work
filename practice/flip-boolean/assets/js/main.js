function reverse(bool) {
	if(typeof(bool) === "boolean"){
        return !bool;
    } else {
        return 'boolean expected';
    };
}

// or 

function reverse(bool) {
	return typeof bool === 'boolean' ? !bool : 'boolean expected';
}