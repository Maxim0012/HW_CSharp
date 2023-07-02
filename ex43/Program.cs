Console.Clear();


const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = ImputLineData(LINE1);
double[] lineData2 = ImputLineData(LINE2);
if (ValidateLines(lineData1, lineData2))

{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уровней y=");
}