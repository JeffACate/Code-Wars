function decode(str) {
    // implement morse decode here
    arr = str.split(' ')
    arr.forEach(element => {
      switch (element) {
        case ".-":
          element = "a";
          break;
        case "-...":
          element = "b";
          break;
        case "-.-.":
          element = "c";
          break;
        case "-..":
          element = "d";
          break;
        case ".":
          element = "e";
          break;
        case "..-."://here
          element = "f";
          break;
        case "--.":
          element = "g";
          break;
        case "....":
          element = "h";
          break;
        case "..":
          element = "i";
          break;
        case ".---":
          element = "j";
          break;
        case "-.-":
          element = "k";
          break;
        case ".-..":
          element = "l";
          break;
        case "--":
          element = "m";
          break;
        case "-.":
          element = "n";
          break;
        case "---":
          element = "o";
          break;
        case ".--.":
          element = "p";
          break;
        case "--.-":
          element = "q";
          break;
        case ".-.":
          element = "r";
          break;
        case "...":
          element = "s";
          break;
        case "-":
          element = "t";
          break;
        case "..-":
          element = "u";
          break;
        case "...-":
          element = "v";
          break;
        case ".--":
          element = "w";
          break;
        case "-..-":
          element = "x";
          break;
        case "-.--":
          element = "y";
          break;
        case "--..":
          element = "z";
          break;
        case ".----":
          element = "1";
          break;
        case "..---":
          element = "2";
          break;
        case "...--":
          element = "3";
          break;
        case "....-":
          element = "4";
          break;
        case ".....":
          element = "5";
          break;
        case "-....":
          element = "6";
          break;
        case "--...":
          element = "7";
          break;
        case "---..":
          element = "8";
          break;
        case "----.":
          element = "9";
          break;
        case "-----":
          element = "0";
          break;
        default:
          element = " ";
            break;
      }
    });
    return str;
  }

console.log(".... . .-.. .-.. ---  .-- --- .-. .-.. -..   → \"hello world\"", decode(".... . .-.. .-.. ---  .-- --- .-. .-.. -..") === "hello world");
console.log(".---- ... -  .- -. -..  ..--- -. -..         → \"1st and 2nd\"", decode(".---- ... -  .- -. -..  ..--- -. -..") === "1st and 2nd");
