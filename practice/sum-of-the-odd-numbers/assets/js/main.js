function addOddToN(n) {
  let counter = n;
  let sum = 0;
  while (counter > 0) {
    sum += counter;
    counter -= 2;
  }
  return sum;
}
