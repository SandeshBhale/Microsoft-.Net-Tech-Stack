import { Component, OnInit } from '@angular/core';
import { Icustomer } from './icustomer';
import { CustomerService } from './customer.service';

@Component({
  selector: 'cust',
  templateUrl: './customer.component.html',
  styleUrl: './customer.component.css',
  providers: [CustomerService]
})
export class CustomerComponent implements OnInit {

  custs: Icustomer[] = [];
  constructor(private custsvr: CustomerService) { }

  ngOnInit(): void {
    this.custsvr.getAllCustomers().subscribe(
      (data) => this.custs = data,
      (err) => alert(JSON.stringify(err))
    )
  }
}
