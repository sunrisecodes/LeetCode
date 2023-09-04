var isSubsequence = function (sub, original) {
  let i = 0;
  let j = 0;
  if (sub.length > original.length) return false;
  while (i < sub.length && j < original.length) {
    if (sub[i] == original[j]) {
      i++;
      j++;
    } else j++;
  }

  return i == sub.length;
};
let str = isSubsequence('abc', 'ahbgdc');
console.log(str);
