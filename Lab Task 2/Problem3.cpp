#include<iostream>
using namespace std;
int main(){
    int m=0;
    int a;
    int b;
    int Array_1 [6]= {1,4,6,3,6,9};
    int Array_3[12];
    for(a=0; a<6;a++){
        for(b=0; b<6;b++){
            if(Array_1[a]==Array_2[b]){
                Array_3[m]=Array_1[a];
                m++;
            }
        }
    }
    if(m!=0)
    for(a=0; a<m;a++)
        cout<<Array_3[a]<<",";
    else
        cout<<"No common element!";


}
