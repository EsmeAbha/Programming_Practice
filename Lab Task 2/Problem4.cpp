#include<iostream>
using namespace std;
int main()
{
    int count=0,n;
    int Array_1[10] = {12,34,54,3665,354,76,562,213,12,10};
    cout<<"Enter a number to search: ";
    cin>>n;
    for(int i=0;i<10;i++){
        if(Array_1[i]==num){
            count++;
        }
    }
    if(count==0)
    cout<<"Number doesn't exist in the array";
    else
    cout<<"The number occurs "<<count<<" times in the array."<<endl;
}
