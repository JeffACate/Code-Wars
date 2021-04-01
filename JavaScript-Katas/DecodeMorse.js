function decode(str) {
    // implement morse decode here
    arr = str.split(' ');
    arr.forEach(element => {
      if(element === ''){
        console.log("| x |");
      }
    });
    return str;
  }

console.log(".... . .-.. .-.. ---  .-- --- .-. .-.. -..   → \"hello world\"", decode(".... . .-.. .-.. ---  .-- --- .-. .-.. -..") === "hello world");
console.log(".---- ... -  .- -. -..  ..--- -. -..         → \"1st and 2nd\"", decode(".---- ... -  .- -. -..  ..--- -. -..") === "1st and 2nd");
