using LeetCode.Q1._LRU_Cache;

var cache = new LRUCache(2);
cache.Put(1, 1);
cache.Put(2, 2);
var ans1 = cache.Get(1);
Console.WriteLine(ans1);
cache.Put(3, 3);
var ans2 = cache.Get(2);
Console.WriteLine(ans2);
cache.Put(4, 4);
var ans3 = cache.Get(1);
Console.WriteLine(ans3);
var ans4 = cache.Get(3);
Console.WriteLine(ans4);
var ans5 = cache.Get(4);
Console.WriteLine(ans5);