#include <iostream>
#include "Vector.h"

using namespace std;

int main()
{
    Vector v1;
    Vector v2(3.2, 5, 7.1);
    Vector v3(v2);
    v3 = 2*v3;
    v1 = v3 - v2;
    cout << v1.X() <<"\t"<<v1.Y() <<"\t"<< v1.Z()<<endl;
    cout << v2.X() <<"\t"<<v2.Y() <<"\t"<< v2.Z()<< endl;
    cout << v3.X() <<"\t"<<v3.Y() <<"\t"<< v3.Z()<< endl;
}
