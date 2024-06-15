import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../employee/employee.service';
import { ActivatedRoute, Route, Router } from '@angular/router';

@Component({
  selector: 'delete',
  templateUrl: './delete-employee.component.html',
  styleUrl: './delete-employee.component.css',
  providers: [EmployeeService]
})
export class DeleteEmployeeComponent implements OnInit {

  emprec: any;
  empid: any;

  constructor(private empsvr: EmployeeService, private art: ActivatedRoute, private rt: Router) { }

  ngOnInit(): void {
    this.art.paramMap.subscribe(
      (data) => this.empid = data.get("eid"),
      (err) => alert("Error !" + JSON.stringify(err))
    );

    this.empsvr.getById(this.empid).subscribe(
      (data) => this.emprec = data,
      (err) => alert("Error" + JSON.stringify(err))
    )
  }

  DeleteEmployee(): void {
    this.empsvr.removeEmployee(this.empid).subscribe(
      (data) => {
        alert("Employee Deleted !!");
        this.rt.navigate(['/employee']);
      },
      (err) => alert("Error!!" + JSON.stringify(err))
    );
  }
}
