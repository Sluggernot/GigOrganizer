#ifndef GRANDPARENT_H
#define GRANDPARENT_H

namespace VecMath
{
    struct Vector
    {
        double x, y, z;

        Vector() { x = 0.0; y = 0.0; z = 0.0; }
        Vector(double xIn, double yIn, double zIn) { x = xIn; y = yIn; z = zIn; }
    };

    Vector VecSubtract(Vector Destination, Vector Position);
    double Magnitude(Vector vecIn);

}
#endif