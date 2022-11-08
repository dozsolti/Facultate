// Fisa bac 2020 varianta 5

#include <pch.h>
#include <iostream>

using namespace std;

int main()
{
	int n, c;
	int m = 0;
	cin >> n;
	while (n != 0) {
		c = n % 10;
		n = n / 10;
		if (c < 5)
			m = m - 2 * c;
		else
			m = m + c;
	}

	if (m == 0)
		cout << "Da";
	else
		cout << m << "Nu";
	return 0;
}/*
n = xyz
----
c = z
n = xy
m = - 2*z
----
c = y
n = x
m = m + y
---
c = x
n = 0
m = m - 2

-2*z+y-2 = 
x=1
y=2
z=0
*/
/*
III.3
#include "pch.h"
#include <iostream>
#include<fstream>
using namespace std;
ifstream f("bac.txt");

using namespace std;

int main() {
	int x, min=-1, max=-1;
	while (f >> x) {
		if (x < 10 || x>99) continue; // Ignor din start numere care nu au 2 cifre
		if (x < min || min==-1) min = x;
		if (max < x || max == -1) max = x;
	}
	if(min == -1)
		cout << "nu exista";
	else
		cout << min-1 <<' '<< max+1<<'\n';
	return 0;
}*/
/*
III.1
bool ePPrim(int n) {
	int m = n;
	long s = 1;
	if (n % 2 == 0)
		s += 2;
	for(int i=3;i<n;i++)
		if(n%i==0)
			s += i;
	s += n;
	return n % 2 == s % 2;
}
int kpn(int a, int b, int k) {
	for (int i = a; i <= b; i++) {
		if (ePPrim(i))
		{
			k--;
			if (k == 0)
				return i;
		}
	}
	return -1;
}
int main()
{
	cout << kpn(27, 50, 3);
	return 0;
}*/
/*
III.2
int main()
{
	char s[100] = "era o selectie reper de desene animate prezenta";

	int s2I = 0;
	char s2[100];
	for (int i = 0; i < 100; i++)
		s2[i] = NULL;

	int cuvantI = 0;
	char cuvant[100];
	for (int i = 0; i < 100; i++)
		cuvant[i] = NULL;

	for (int i = 0; i < 100; i++)
	{
		if (s[i] == ' ' || s[i] == NULL) {
			if (cuvantI > 0)
				cout << cuvant << " " << cuvantI << '\n';

			for (int j = 0; j < cuvantI; j++) {
				if (cuvantI % 2 == 0)
					s2[s2I] = cuvant[j];
				else
					s2[s2I] = cuvant[cuvantI - 1 - j];
				s2I++;
			}

			s2[s2I] = s[i]; // pentru spatiu sau NULL
			s2I++;

			// Golire:
			for (int i = 0; i < 100; i++)
				cuvant[i] = NULL;
			cuvantI = 0;
		}
		else {
			cuvant[cuvantI] = s[i];
			cuvantI++;
		}
	}
	if (strcmp(s, s2) == 0)
		cout << "nu exista";
	else
		cout << s2;

	return 0;
}*/
