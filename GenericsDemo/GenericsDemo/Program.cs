using GenericsDemo;
using static GenericsDemo.SampleDemo;

int[]
    intArray = { 1, 2, 3, 4, 5 };
double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
//Program.toPrint(intArray);
//Program.toPrint(doubleArray);
//Program.toPrint(charArray);

SampleDemo.toPrint<int>(intArray);
SampleDemo.toPrint<double>(doubleArray);
SampleDemo.toPrint<char>(charArray);