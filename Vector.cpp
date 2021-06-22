#include "Vector.h"
#include <math.h>

namespace VecMath
{

    Vector VecSubtract(Vector Destination, Vector Position)
    {
        VecMath::Vector toReturn;
        toReturn.x = Destination.x - Position.x;
        toReturn.y = Destination.y - Position.y;
        toReturn.z = Destination.z - Position.z;

        return toReturn;
    };

    double Magnitude(Vector vecIn)
    {
        return sqrt(vecIn.x * vecIn.x + vecIn.y * vecIn.y + vecIn.z * vecIn.z);
    }

}