import { Injectable } from '@angular/core';
import { Depart } from './alldata'
@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
deplist:Depart[]=
[
  {Department:1,Name:'Engineering',Groupname:'Research and Development',Date:new Date()},
  {Department:2,Name:'Tool Design',Groupname:'Research and Development',Date:new Date()},
  {Department:3,Name:'Sales',Groupname:'Sales and Marketing',Date:new Date()},
  {Department:4,Name:'Marketing',Groupname:'Sales and Marketing',Date:new Date()},

]
  constructor() { }
  getlist()
  {
    return this.deplist
  }
  save(dep:Depart)
  {
    this.deplist.push(dep);
    dep.Date=new Date();
  }
  update1(dep:Depart,index:number)
  {
     this.deplist[index]=dep;
     dep.Date=new Date();
  }
  delete1(index :number)
  {
    this.deplist.splice(index,1);
  }
}
