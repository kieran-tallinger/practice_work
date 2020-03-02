function pHName(pH) {
  if (pH < 0 || pH > 14) return 'invalid';
  if (pH > 7) return 'alkaline';
  if (pH < 7) return 'acidic';
  return 'neutral';
}
