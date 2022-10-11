#include <iostream>
using namespace std;

struct Student
{
    int id;
    int completedCredit;
    double CGPA;
};
bool check(int j, Student student[3], int n){
    bool l;
    for(int i=0;i<10;i++){
        if((student[i].id == n)&&(i=!j)){
            l=true;
        }
    }
    return l;
}
int main()
{
   struct Student student[3];
   int n;
   for(int i=0; i<3; i++)
   {
       cout<<"Student ID: ";
       cin>>n;
       if(check(i, S, n)){
        cout<<"INFORMATION of this student already exist!"<<endl;
        continue;
        i--;
       }else{
       student[i].id = n;
       cout<<"Credit Completed: ";
       cin>>student[i].completedCredit;
       cout<<"CGPA: ";
       cin>>student[i].CGPA;}

    }


   cout<<"Student, earned CGAP more than 3.75 : "<<endl;
   for(int i=0;i<3;i++)
   {
       if(student[i].CGPA > 3.75)
       {
            cout<<student[i].id<<endl;
       }
   }

   cout<<"\nStudent, completed more than 50 credits : ";
   for(int i=0;i<3;i++)
   {
       if(student[i].completedCredit > 50)
       {
            cout<<student[i].id<<endl;
       }
   }
   return 0;
}
