#include <iostream>
using namespace std;
int main()
{
    int i;
    int k;
    int arr1[5]={21,26,29,11,15};
    int arr2[7]={10,5,9,13,1,6,14};
    int arr3[12];

    cout<<"Array 1 : ";
    for(i=0;i<5;i++)
    {
        cout<<arr1[i] <<",";
    }
    cout<<"\nArray 2 : ";
    for(k=0;k<7;k++)
    {
        cout<<arr2[k]<<",";
    }
    cout<<"\nMerged array in reverse order: \n";
    int j=0;
    for(int i=0; i<12; i++){
        if(i<5){
            arr3[i]=arr1[i];
        }
        else
        {
            arr3[i]=arr1[j];
            j++;
        }
    }
    for(k=12;k>=0;k--)
    {
        cout<<arr3[k]<<",";
    }

}
