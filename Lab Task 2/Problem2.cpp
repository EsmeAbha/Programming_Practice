#include<iostream>
using namespace std;
int main(){
    int a;
    int b;
    int c=0;
    int Array_1 [6]= {1,4,6,3,6,9};
    int Array_2 [6]= {5,30,7,10,2,60};
    int Array_3[12];
    for(int a=0; a<6;a++){
        for(int b=0; b<6;b++){
            if(Array_1[a]==Array_2[b]){
                Array_3[c]=Array_1[a];
                c++;
            }
        }
    }
    if(c!=0)
    for(int a=0; a<c;a++)
        cout<<Array_3[a]<<",";
    else
        cout<<"No common element in the array!";


}
