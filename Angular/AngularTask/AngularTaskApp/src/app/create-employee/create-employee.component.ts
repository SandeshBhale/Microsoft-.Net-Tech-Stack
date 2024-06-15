import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../employee/employee.service';
import { Router } from '@angular/router';
import { FormControl, FormGroup } from '@angular/forms';
import { Department } from '../employee/department';

@Component({
  selector: 'create',
  templateUrl: './create-employee.component.html',
  styleUrl: './create-employee.component.css',
  providers: [EmployeeService]
})
export class CreateEmployeeComponent implements OnInit {

  Dept: Department[] = [];
  cfrm: any;
  constructor(private empsvr: EmployeeService, private rt: Router) { }

  ngOnInit(): void {
    this.cfrm = new FormGroup({

      empName: new FormControl,
      designation: new FormControl,
      empSal: new FormControl,
      address: new FormControl,
      deptId: new FormControl(0)

    });

    this.empsvr.getAllDepartments().subscribe(
      (data) => {
        this.Dept = data;
        console.log(this.Dept)
      },
      (err) => alert("Error" + JSON.stringify(err))
    );
  }

  CreateEmp(): void {
    this.empsvr.createEmp(this.cfrm.value).subscribe(
      (data) => {
        alert("Employee Created !!");
        this.rt.navigate(['/employee'])
      },
      (err) => alert("Error" + JSON.stringify(err))
    );
  }

}
