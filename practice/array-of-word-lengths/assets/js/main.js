sampleStrArr = [
  'circumnavigate',
  'pie',
  'hello'
]
function wordLengths(arr) {
  let lengthArr = [];
  arr.forEach(function (str){
    let strLength = str.length
    lengthArr.push(strLength);
  })
  return lengthArr
}
