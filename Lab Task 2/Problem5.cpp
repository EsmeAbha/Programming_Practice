#include<iostream>
#include<string>
using namespace std;
int main() {
    int array_1[10];
    for(int i=0;i<10;i++) {
        cout<<"Enter the elements of array :"<<endl;
        cin>>array_1[i];

    }

    for(int i=0;i<9;i++) {
        int count=1;
        for(int j=i+1;j<10;j++) {
            if(array_1[i]==array_1[j]) count++;
        }
        cout<<"The number "<<array_1[i]<<" is occured "<<count<<" times"<<"\n";
    }
}

