function firstLast(arr) {
    const storArr = [];
	storArr.push(arr.shift());
	storArr.push(arr.pop());
    return storArr;
}