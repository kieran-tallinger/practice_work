const sampleStr1 = 'hello'
const sampleStr2 = 'hello, world'
function hasSpaces(str) {
  for (let i = 0;i<str.length;i++){
    if (str[i] === ' '){
      return true
    }
  }
  return false
}
