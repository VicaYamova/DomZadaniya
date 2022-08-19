int A = -1;
int B = 280;

int max = A;
int min = B;

if(A > max) max = A;
if(B > max) max = B;

if(A < min) min = A;
if(B < min) min = B;

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);