// See https://aka.ms/new-console-template for more information
using OtusHW_2;
using System.Collections;

List<int> list = new List<int>();
ArrayList arrayList = new ArrayList();
LinkedList<int> linkedList = new LinkedList<int>();

Utils.addOneMlnElements(ref list);
Utils.addOneMlnElements(ref arrayList);
Utils.addOneMlnElements(ref linkedList);

Console.WriteLine("------------------------------");

Utils.find496753(list);
Utils.find496753(arrayList);
Utils.find496753(linkedList);

Console.WriteLine("------------------------------");

Utils.getDivisibleBy777(list);
Utils.getDivisibleBy777(arrayList);
Utils.getDivisibleBy777(linkedList);




