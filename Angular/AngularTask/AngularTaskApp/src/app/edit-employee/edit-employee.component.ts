import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../employee/employee.service';
import { AnimateTimings } from '@angular/animations';
import { ActivatedRoute, Route, Router } from '@angular/router';
import { FormBuilder } from '@angular/forms';
import { Department } from '../employee/department';

@Component({
  selector: 'edit',
  templateUrl: './edit-employee.component.html',
  styleUrl: './edit-employee.component.css',
  providers: [EmployeeService]
})
export class EditEmployeeComponent implements OnInit {

  Dept: Department[] = [];
  EmpId: any;
  cfrm: any;

  constructor(private art: ActivatedRoute, private empsvr: EmployeeService, private fb: FormBuilder, private rt: Router) { }

  ngOnInit(): void {
    this.art.paramMap.subscribe(
      (data) => this.EmpId = data.get('eid'),
      (err) => alert("Error" + JSON.stringify(err))
    );

    this.empsvr.getAllDepartments().subscribe(
      (data) => {
        this.Dept = data;
        console.log(this.Dept)
      },
      (err) => alert("Error" + JSON.stringify(err))
    );

    this.cfrm = this.fb.group(
      {
        empId: [],
        empName: [],
        address: [],
        deptId: [],
        empSal: [],
        designation: []
      }
    )

    this.empsvr.getById(this.EmpId).subscribe(
      (data) => this.cfrm.patchValue(data),
      (err) => alert("Error !" + JSON.stringify(err))
    )
  }

  UpdateEmployee(): void {
    this.empsvr.modifyEmployee(this.cfrm.value).subscribe(
      (data) => {
        alert("Employee Updated !!");
        this.rt.navigate(['/employee'])
      },
      (err) => alert("Error !" + JSON.stringify(err))
    );
  }
}
