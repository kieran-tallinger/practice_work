function changeColor(event){
  $(event.currentTarget).removeClass('red').addClass('green');
}

function addEventHandler(){
  $('.box').on('click', changeColor);
}

$('document').ready(addEventHandler);
