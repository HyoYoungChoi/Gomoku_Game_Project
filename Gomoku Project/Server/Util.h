#pragma once
#ifndef GOMOKU_UTIL_H
#define GOMOKU_UTIL_H
using namespace std;
#include <vector>
#include <sstream>
class Util {
public:
	//�����ڸ� �������� ��ū�� �и�.
	vector<string> getTokens(string input, char delimiter);
};

#endif