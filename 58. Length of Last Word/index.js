var lengthOfLastWord = function (s) {
  const str = s.trim().split(' ');
  let last = str[str.length - 1];
  return last.length;
};

console.log(lengthOfLastWord('luffy is still joyboy'));
