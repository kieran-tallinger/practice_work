var tree = {
  mainString: "*",
  howManyRows: 20,
  spaces: 0,
  astriks: 0,
  shiftValues: function () {
    this.spaces = this.spaces - 1;
    this.astriks = this.astriks + 1;
  },
  growStringSpaces: function (inputFromSpaces) {
    for (var spaceIndex = inputFromSpaces - 1; spaceIndex > 0; spaceIndex--) {
      this.mainString = " " + this.mainString + " ";
    };
  },
  growStringAstriks: function (inputFromAstriks) {
    for (var astrikIndex = inputFromAstriks; astrikIndex > 0; astrikIndex--) {
      this.mainString = "*" + this.mainString + "*";
    };
  },
  makeTree: function (inputHowManyRows) {
    for (var rowsIndex = 1; rowsIndex <= inputHowManyRows; rowsIndex++) {
      this.growStringAstriks(this.astriks);
      this.growStringSpaces(this.spaces);
      this.shiftValues();
      console.log(this.mainString);
      this.mainString = "*";
    };
  },
  generateTree: function () {
    this.spaces = this.howManyRows;
    this.makeTree(this.howManyRows);
  },
}

tree.generateTree();
