module.exports = {
  TestRunner: class TestRunner {

    // input: string
    // output: string
    runStringTests(tests, temp) {
      tests.forEach((test) => {
        console.log(`${test.actual} | ${test.expected} => ${this.assert(temp(test.actual), test.expected)}`);
      })
    }
    
    // input: arr
    // output: arr
    runArrTests(tests, temp){
      tests.forEach((test) => {
        console.log(`${temp(test.actual).toString()} | ${test.expected.toString()} => ${this.assert(temp(test.actual).toString(), test.expected.toString())}`);
      })
    }

    //are equal?
    assert(actual, expected) {
      return actual === expected;
    }
  }
};
