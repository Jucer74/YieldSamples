using BenchmarkDotNet.Running;
using System.Diagnostics;
using YieldConsole;

/*------------*/
/*-- Define --*/
/*------------*/
var methodType = MethodType.Benchmarks;
int quantity = 5;

/*----------*/
/*-- Main --*/
/*----------*/

#region Normal

if (methodType == MethodType.Normal)
{
    Stopwatch stopWatch = new Stopwatch();
    stopWatch.Start();
    Console.WriteLine("Yield Return-Start.");
    ProcessPeople(quantity);
    Console.WriteLine("Yield Return-End.");
    stopWatch.Stop();
    TimeSpan ts = stopWatch.Elapsed;
    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
    Console.WriteLine("RunTime = {0}", elapsedTime);
}

#endregion Normal

#region Benchmarks

if (methodType == MethodType.Benchmarks)
{
   var summary = BenchmarkRunner.Run<YieldBenchmarks>();
    Console.WriteLine(summary.Table);   
}

#endregion Benchmarks

/*---------------*/
/*-- Functions --*/
/*---------------*/
void ProcessPeople(int quantity)
{
    var people = YieldReturn.GetPeople(quantity);
    //var people = YieldReturn.GetPeopleYield(quantity);

    Console.WriteLine("Main Process People");

    foreach (var person in people)
    {
        Console.WriteLine($"{person.Id}, {person.FirstName}, {person.LastName}");
    }
}