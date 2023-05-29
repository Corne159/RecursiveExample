using RecursiveTutorial;


var node = new Node();

int t4Node1 = 100;
int t4Node2 = 25;
int t4Node3 = 75;
int t4Node4 = 50;

object t3Node1 = new { op = "div", val1 = t4Node1, val2 = t4Node2 };
object t3Node2 = new { op = "sub", val1 = t4Node3, val2 = t4Node4 };

object t2Node2 = new { op = "mult", val1 = t3Node1, val2 = t3Node2 };

object t1Node1 = new { op = "add", val1 = 5, val2 = t2Node2 };

//Build structure

var a = node.DoCalculation(t1Node1);
Console.WriteLine(a);