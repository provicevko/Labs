#include <iostream>
#include <cstring>
#include <string>
#include "../Lab2Dll/TextCont.h"

using namespace std;
char* ConvertToChar(string);

int main()
{
	const int countStr = 5;
	char** arr = new char* [countStr];
	arr[0] = ConvertToChar("HGDJUBEHJ");
	arr[1] = ConvertToChar("Hello6575world!");
	arr[2] = ConvertToChar("Hello world!");
	arr[3] = ConvertToChar("457HGDJUBEHJ");
	arr[4] = ConvertToChar("HGgfhftgjDJUBEHJ");

	Lab2Dll::TextCont obj(arr, countStr);
	obj.AddStr(ConvertToChar("erhrlotbnt"));
	obj.DeleteStr(3);
	obj.DeleteStr(4);
	obj.AddStr(ConvertToChar("12345ghg"));
	obj.GetAverageLength();
	obj.PersentVowels();
	obj.DelStrwithSubstr(ConvertToChar("lo"));
	//obj.ClearText();

	
}

char* ConvertToChar(string str) 
{
	str += "\0";
	char* convertedStr = new char[50];
	strcpy_s(convertedStr, str.length()+1, str.c_str());
	return convertedStr;
}
