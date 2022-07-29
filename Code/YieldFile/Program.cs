using System.Diagnostics;


/*----------*/
/*-- Main --*/
/*----------*/


Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
Console.WriteLine("Yield Return-Start.");
ProcessFile("");
Console.WriteLine("Yield Return-End.");
stopWatch.Stop();
TimeSpan ts = stopWatch.Elapsed;
string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
Console.WriteLine("RunTime = {0}", elapsedTime);


/*---------------*/
/*-- Functions --*/
/*---------------*/
void ProcessFile(string fileName)
{
    throw new NotImplementedException();
}