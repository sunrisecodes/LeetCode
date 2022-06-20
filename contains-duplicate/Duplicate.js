// var nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2];
var nums = [];
var containsDuplicate = function (nums) {
  var count = 0;

  for (var i = 0; i < nums.length; i++) {
    for (var j = i + 1; j < nums.length; j++) {
      if (nums[i] === nums[j]) {
        count++;
        break;
      } else {
        continue;
      }
    }
  }
  if (count === 0) {
    return false;
  } else return true;
};
containsDuplicate(nums);
