#pragma once
#include "ParentC.h"
class KidC :
    public ParentC
{

    int a, b, c;

public:
    KidC();

    inline int GetA() { return a; }
//    void SetXK(int xIn) { x = xIn; }
//    int GetXK() { GetX(); }

};

