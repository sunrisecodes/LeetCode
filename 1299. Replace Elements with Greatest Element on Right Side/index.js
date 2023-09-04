var replaceElements = function (arr) {
  for (let index = 0; index < arr.length; index++) {
    const rest = arr.slice(index + 1, arr.length);
    if (rest.length == 0) {
      arr[index] = -1;
    } else {
      const max = Math.max(...rest);
      arr[index] = max;
    }
  }
  return arr;
};

const result = replaceElements([17, 18, 5, 4, 6, 1]);

console.log(result);
