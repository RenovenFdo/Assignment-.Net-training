import { Component, OnInit } from '@angular/core';
import { Depart } from '../alldata';
import {EmployeeService} from '../employee.service'
import { Router } from '@angular/router';
import {NgForm} from '@angular/forms'


@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.scss']
})
export class CreateComponent implements OnInit {
  depart=new Depart;
  constructor(private es: EmployeeService ,private route:Router) { }

  ngOnInit() {
  }
  savedepartment():void{
    this.es.save(this.depart);
      this.route.navigate(['list']);
    }
}
