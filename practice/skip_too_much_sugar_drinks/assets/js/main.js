var sampleDrinks = ['cola', 'fanta','water']
function skipTooMuchSugarDrinks(drinks) {
  return drinks.filter(function(drink){
    if (drink !== 'cola' && drink !== 'fanta'){
      return drink;
    }
  });
}
