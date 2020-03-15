#pragma once
#ifndef GOMOKU_UTIL_H
#define GOMOKU_UTIL_H
using namespace std;
#include <vector>
#include <sstream>
class Util {
public:
	//구분자를 기준으로 토큰을 분리.
	vector<string> getTokens(string input, char delimiter);
};

#endif