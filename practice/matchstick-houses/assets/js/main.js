function matchHouses(step) {
  let sticks = 0;
  for (let i = 1; i <= step; ++i){
    if(i === 1) {
      sticks += 6;
    } else {
      sticks += 5;
    }
  }
  return sticks;
}
