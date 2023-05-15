#include <iostream>
#include "NeroNet.h"
using namespace std;

int main()
{

    //cout << "Hello World!\n";

    double km = 100;
    double miles = 62.1371;
    NeroNet neiron = NeroNet();

    neiron.Train(km, miles);

    //"Iteration: " + (char)neiron.Iteration + "Error :" + (char)neiron.LastError;

    cout << "Iteration: \t" << neiron.Iteration << "Error :\t" << neiron.LastError <<"\n";

    if (neiron.IsDone)
    {
        cout << "Traning Done!\n";
    }


    cout << neiron.ProcessInputData(100) << "mils in 100 km\n";
    cout << neiron.ProcessInputData(541) << "mils in 541 km\n";
    cout << neiron.RestoreInputData(10) <<"km in 10 mils\n";
    

}