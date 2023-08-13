module.exports = {
  TestRunner: class TestRunner {
    runTests(tests, temp) {
      tests.forEach((test) => {
        console.log(`${test.actual} | ${test.expected} => ${this.assert(temp(test.actual), test.expected)}`);
      })
    }

    assert(actual, expected) {
      return actual === expected;
    }
  }
};
