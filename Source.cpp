
#include <iostream>
#include "ParentC.h"
#include "KidC.h"
#include "Vector.h"
using namespace std;

void VectorPrint(VecMath::Vector vec)
{
	cout << "Vec X: " << vec.x << " Y: " << vec.y << " Z: " << vec.z << endl;
}

int main()
{

	//ParentC par1;
	//cout << par1.GetX() << endl;
	//par1.SetX(10);
	//cout << par1.GetX() << endl;
	//cout << "Sizeof Parent: " << sizeof(par1) << endl;

	//KidC chil1;
	//cout << chil1.GetA() << endl;
	//cout << "Sizeof Child: " << sizeof(chil1) << endl;

	//cout << "ChildX: " << chil1.GetX() << endl;
	//chil1.SetX(5);
	//cout << "ChildX: " << chil1.GetX() << endl;

	cout << "Test\n\n";

	printf("Assertion: %s : %d ERROR\n\n", __FILE__, __LINE__);

	VecMath::Vector vec1(1.1, 2.2, 3.3), vec2(3.3, 2.2, 1.1);
	VectorPrint(vec1);
	VectorPrint(vec2);

	VectorPrint(VecMath::VecSubtract(vec1, vec2));

	return 0;
}