// See https://aka.ms/new-console-template for more information
using Charles_Assignment1;

startMission();

void startMission()
{
    View v = new View();
    Process p = new Process();
    double width;
    double height;
    
    v.Welcome();
    v.LineBreak();
    height = v.GetDimension("hieght");
    width = v.GetDimension("width");
    v.LineBreak();
    v.DisplayResult(p.Area(height, width),"area");
    v.DisplayResult(p.Perimiter(height, width), "perimiter");
}