#pragma once
#include <ctype.h>
#include <cstring>
using namespace std;

namespace Lab2Dll
{
    class String
    {
    public:
        char* Str;
        String(){}
        String(char* line)
        {
            if (islower(line[0])) line[0] = toupper(line[0]);
            Str = line;
        }
    };
}
