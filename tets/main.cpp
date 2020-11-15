#include "math.h"
#include <iostream>
#include "extended/extended.h"
#include "extended/super/super.h"
using namespace std;
int main()
{
    cout << sum(1, 2) << endl;
    int a, b;
    cin >> a >> b;
    cout << extended(a , b) << endl;
    cout << super(a, b) << endl;
    return 0;
}