#include <iostream>
#include <time.h>

int main() {
    long a = 0;
    long b = 2;
    long c = 3;
    clock_t start = clock();
    for (int i = 0; i <= 100000000; i++)
        a += b * 2 + c - i;

    clock_t end = clock() - start;
    std::cout << " a = " << a << "\n";
    std::cout << (float)(end * 1000) << " ms ";
}
