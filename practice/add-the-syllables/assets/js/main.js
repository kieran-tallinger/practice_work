function countSyllables(str) {
  const regex = /\w[aeiou]/ig;
  const matches = str.match(regex);
  return matches.length;
}
