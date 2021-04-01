function decode(str) {
    // implement morse decode here
    arr = str.split(' ')
    arr.forEach(element => {
      switch (key) {
        case ".-":
          console.log(a);
          break;
        case "-...":
          console.log(b);
          break;
        case "-.-.":
          console.log(c);
          break;
        case "-..":
          console.log(d);
          break;
        case ".":
          console.log(e);
          break;
        case "..-."://here
          console.log(f);
          break;
        case ".-":
          console.log(g);
          break;
        case ".-":
          console.log(h);
          break;
        case ".-":
          console.log(i);
          break;
        case ".-":
          console.log(j);
          break;
        case ".-":
          console.log(k);
          break;
        case ".-":
          console.log(l);
          break;
        case ".-":
          console.log(m);
          break;
        case ".-":
          console.log(n);
          break;
        case ".-":
          console.log(o);
          break;
        case ".-":
          console.log(p);
          break;
        case ".-":
          console.log(q);
          break;
        case ".-":
          console.log(r);
          break;
        case ".-":
          console.log(s);
          break;
        case ".-":
          console.log(t);
          break;
        case ".-":
          console.log(u);
          break;
        case ".-":
          console.log(v);
          break;
        case ".-":
          console.log(w);
          break;
        case ".-":
          console.log(x);
          break;
        case ".-":
          console.log(y);
          break;
        case ".-":
          console.log(z);
          break;
        default:
          console.log(" ");
            break;
      }
    });
    return str;
  }

console.log(".... . .-.. .-.. ---  .-- --- .-. .-.. -..   → \"hello world\"", decode(".... . .-.. .-.. ---  .-- --- .-. .-.. -..") === "hello world");
console.log(".---- ... -  .- -. -..  ..--- -. -..         → \"1st and 2nd\"", decode(".---- ... -  .- -. -..  ..--- -. -..") === "1st and 2nd");
