#include "pch.h"

extern "C" __declspec(dllexport) int __cdecl DiffOf2Nums(int a, int b)
{   
    int d;
    if (a > b) {
        d = a - b;
    }
    else {
        d = b - a;
    }
	return d;

}


extern "C" __declspec(dllexport) int __stdcall SumOf2Nums(int a, int b) {
	int s = a + b;
	return s;
}
