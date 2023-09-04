var groupAnagrams = function (strs) {
  let sorted = {} ;

  for(let str of strs){
      let sortedKey = str.split("").sort().join("");
          
      (sorted[sortedKey]) ? sorted[sortedKey].push(str) : sorted[sortedKey]=[str];
  }
  return object.values(sorted)

};
groupAnagrams(["eat","tea","tan","ate","nat","bat"])
// console.log(sorted)