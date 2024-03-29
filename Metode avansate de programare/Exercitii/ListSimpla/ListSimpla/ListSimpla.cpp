// ListSimpla.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
struct Nod {
	int val;
	Nod* next;
};
void AddBegin(Nod* l, int newVal) {
	Nod* first = l;
	Nod* n = new Nod();
	n->val = newVal;
	n->next = l;
	l = n;
}
void AddEnd(Nod* l, int newVal) {
	Nod* last;
	for (last = l; last->next; last = last->next);
	Nod* n = new Nod();
	n->val = newVal;
	n->next = NULL;
	last->next = n;
}

void Print(Nod* l) {
	for (Nod* i = l; i; i = i->next)
		std::cout << i->val << " ";
}
int main()
{
	Nod* list = new Nod();
	for (int i = 1; i <= 5; i++)
		AddEnd(list, i);
	Print(list);
	std::cout << "\n";
	AddBegin(list, -1);
	Print(list);

    std::cout << "Hello World!\n"; 
	
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
