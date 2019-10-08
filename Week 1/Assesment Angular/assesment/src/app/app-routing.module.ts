import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
 //import {NavComponent} from './nav/nav.component'
import { CreateComponent} from './create/create.component'
import {ListComponent} from './list/list.component'
import { AppComponent } from './app.component';

const routes: Routes = [
  {path:'',component:AppComponent},
  {path:'list' , component:ListComponent},
  {path:'create' , component:CreateComponent}
];
 
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
