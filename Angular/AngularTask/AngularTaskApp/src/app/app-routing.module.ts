import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmployeeComponent } from './employee/employee.component';
import { CreateEmployeeComponent } from './create-employee/create-employee.component';
import { EditEmployeeComponent } from './edit-employee/edit-employee.component';
import { DeleteEmployeeComponent } from './delete-employee/delete-employee.component';

const routes: Routes = [
  { path: 'employee', component: EmployeeComponent },
  { path: 'create', component: CreateEmployeeComponent },
  { path: 'edit/:eid', component: EditEmployeeComponent },
  { path: 'delete/:eid', component: DeleteEmployeeComponent },
  { path: '', redirectTo: 'employee', pathMatch: 'full' },
  { path: '**', component: EmployeeComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
