#define MyFunctions _declspec(dllexport)

extern "C" {

	MyFunctions double AddNumbers(double a, double b)
	{
		return a + b;
	}
}