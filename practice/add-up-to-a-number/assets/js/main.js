function addUp(num) {
  if (num === 1) {
    return num
  }
  return num + addUp(num - 1);
}
