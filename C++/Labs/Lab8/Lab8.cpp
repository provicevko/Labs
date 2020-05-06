#include <iostream>
#include <exception>
#include <stdexcept>

int Partition(char[], int, int);
void Quicksort(char[], int, int);
void DownSort(char[]);

int main()
{
    char array[] = { 'A','c','C','b','B','a','5' };
    void (*del)(char[]);
    del = DownSort;
    del(array);
}

void DownSort(char array[]) {
    if (array == NULL) {
        throw std::invalid_argument("Division on zero! Log(e,1) = 0");
    }
    int size = sizeof(array) / sizeof(array[0]);
    Quicksort(array, 0, size);
}

int Partition(char array[], int start, int end)
{
    char temp;
    int marker = start;
    for (int i = start; i <= end; i++)
    {
        if (array[i] > array[end])
        {
            temp = array[marker];
            array[marker] = array[i];
            array[i] = temp;
            marker++;
        }
    }
    temp = array[marker];
    array[marker] = array[end];
    array[end] = temp;
    return marker;
}

void Quicksort(char array[], int start, int end)
{
    if (start >= end)
    {
        return;
    }
    int pivot = Partition(array, start, end);
    Quicksort(array, start, pivot - 1);
    Quicksort(array, pivot + 1, end);
}

