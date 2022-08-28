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
    height = v.GetDimension("hieght");
    width = v.GetDimension("width");
    v.displayResult(p.area(height, width),"area");
    v.displayResult(p.perimiter(height, width), "perimiter");
}