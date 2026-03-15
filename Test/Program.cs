using LeetCode._1622._Fancy_Sequence;

var fancy = new Fancy();

fancy.Append(2);   // fancy sequence: [2]
fancy.AddAll(3);   // fancy sequence: [2+3] -> [5]
fancy.Append(7);   // fancy sequence: [5, 7]
fancy.MultAll(2);  // fancy sequence: [5*2, 7*2] -> [10, 14]
var ans1 = fancy.GetIndex(0); // return 10
Console.WriteLine(ans1);
fancy.AddAll(3);   // fancy sequence: [10+3, 14+3] -> [13, 17]
fancy.Append(10);  // fancy sequence: [13, 17, 10]
fancy.MultAll(2);  // fancy sequence: [13*2, 17*2, 10*2] -> [26, 34, 20]
var ans2 = fancy.GetIndex(0); // return 26
Console.WriteLine(ans2);
var ans3 = fancy.GetIndex(1); // return 34
Console.WriteLine(ans3);
var ans4 = fancy.GetIndex(2); // return 20
Console.WriteLine(ans4);