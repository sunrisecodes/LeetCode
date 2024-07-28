var reversed = function (str) {
  const newStr = str.split('').reverse();

  return newStr.join('');
};

console.log(reversed('Hello'));
