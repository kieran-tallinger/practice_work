function minMax(arr) {
  let min = arr[0];
  let max = arr[0];

  arr.forEach(value => {
    if (min > value) {
      min = value
    }
  })
  if (arr.length === 1) {
    max = min;
  } else {
    arr.forEach(value => {
      if (max < value) {
        max = value
      }
    })
  }
  return [min, max];
}
