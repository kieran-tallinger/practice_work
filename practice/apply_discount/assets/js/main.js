function getDiscounts(nums, d) {
  const dec = d.split('%')
  const point = dec[0]/100
  return nums.map(elem => elem * point)
}
