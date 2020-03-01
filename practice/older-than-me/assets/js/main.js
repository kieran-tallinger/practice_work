class Person {
  constructor(name, age) {
    this.name = name;
    this.age = age;
  }

  compareAge(other) {
    if(this.age < other.age) return `${other.name} is older than me.`;
    if(this.age > other.age) return `${other.name} is younger than me.`;
    return `${other.name} is the same age as me.`;
  }
}
