function addOddToN(n) {
  let counter = n;
  let sum = 0;
  while (counter > 0) {
    sum += counter;
    counter -= 2;
  }
  return sum;
}

function addOddToN2(n) {
  if (n === 1) return 1
  return n + addOddToN2(n - 2)
}
