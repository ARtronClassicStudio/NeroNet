#pragma once
class NeroNet
{
    
public: double weight = 0.5;
public: double LastError;
public: double Smoothing = 0.00001;
public: double ProcessInputData(double input) { return input * weight; }
public: double RestoreInputData(double output) { return output / weight; }
public: bool IsDone = false;
public: int Iteration = 0;


public: void Train(double input, double expectedResult)
    {
        int i = 0;
        do
        {
            i++;
            double actualResult = input * weight;
            LastError = expectedResult - actualResult;
            double correction = (LastError / actualResult) * Smoothing;
            weight += correction;
            Iteration = i;

        } while (LastError > Smoothing || LastError < -Smoothing);
        IsDone = true;
    }
};

