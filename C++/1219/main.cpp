#include <string>
#include <iostream>
using namespace std;
using namespace System;

void MarshalString(String^ s, stdf::string& os) {
    using namespace Runtime::InteropServices;
    const char* chars =
        (const char*)(Marshal::StringToHGlobalAnsi(s)).ToPointer();
    os = chars;
    Marshal::FreeHGlobal(IntPtr((void*)chars));
}

void MarshalString(String^ s, wstring& os) {
    using namespace Runtime::InteropServices;
    const wchar_t* chars =
        (const wchar_t*)(Marshal::StringToHGlobalUni(s)).ToPointer();
    os = chars;
    Marshal::FreeHGlobal(IntPtr((void*)chars));
}

int main() {
    string a = "test";
    wstring b = L"test2";
    String^ c = gcnew String("abcd");

    cout << a << endl;
    MarshalString(c, a);
    c = "efgh";
    MarshalString(c, b);
    cout << a << endl;
    wcout << b << endl;
}