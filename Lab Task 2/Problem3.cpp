#include<iostream>
using namespace std;
int main()
{
    int count=0;
    int count1=0;
    int arr[]={112,223,21,4,343,5,33,211,112,89};
    int arr2[10];
    for(int i=0;i<10;i++){
        int j;
        for(j=0;j<i;j++)
            if(arr[i]==arr[j]){
              count1++;
               break;
            }
            if(i==j){
              arr2[count]=arr[i];
              count++;
            }
    }
    if(count1==0){
      cout<<"\nThe elements are already unique!\n";
    }
    for(int i=0;i<count;i++){
        cout<<arr2[i]<<",";
    }
    return 0;
}
