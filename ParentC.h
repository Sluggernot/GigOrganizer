#pragma once


class ParentC
{
protected:
    int x, y, z;

public:
    ParentC();

    inline int GetX() { return x; }
    inline void SetX(int inX) { x = inX; }
};

