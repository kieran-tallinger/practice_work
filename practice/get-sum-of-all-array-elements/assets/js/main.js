function getSumOfItems(arr) {
  const reducer = (accumulator, currentVal) => accumulator + currentVal;
  return arr.reduce(reducer)
}
