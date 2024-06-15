import { Component, OnInit } from '@angular/core';
import { EmployeeService } from './employee.service';
import { IEmployee } from './iemployee';

@Component({
  selector: 'employee',
  templateUrl: './employee.component.html',
  styleUrl: './employee.component.css',
  providers: [EmployeeService]
})
export class EmployeeComponent implements OnInit {

  emps: IEmployee[] = []

  constructor(private empsvr: EmployeeService) { }

  ngOnInit(): void {
    this.empsvr.getAllEmployees().subscribe(

      (data) => this.emps = (data),
      (err) => alert(JSON.stringify(err))
    )
  }

}
