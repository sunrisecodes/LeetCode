var s = "",
  t = "";
var isAnagram = function (s, t) {
  if (s.length === t.length) {
    var arrOfs = s.split("").sort();
    var arrOft = t.split("").sort();

    for (var i = 0; i < arrOfs.length; i++) {
      if (arrOfs[i] === arrOft[i]) {
        continue;
      } else return false;
    }
    return true;
  } else return false;
};
isAnagram(s, t);
