import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../employee.service';
import { Depart } from '../alldata';
@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {
  deplist1:Depart[];
  depart:Depart;
  updatediv=false;
  constructor(private es:EmployeeService) { 
    this.deplist1=this.es.getlist();

  }

  ngOnInit() {
  }
  edit(index:number)
  {   
     this.updatediv=true; 
     this.depart=this.deplist1[index];
    this.es.update1(this.depart,index);  
   }
  delete(index:number)
  {
    this.es.delete1(index);
   }
   update()
   {
     this.updatediv=false;
   }
}
