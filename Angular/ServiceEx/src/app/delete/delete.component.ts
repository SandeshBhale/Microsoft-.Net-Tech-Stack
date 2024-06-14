import { Component, OnInit } from '@angular/core';
import { CustomerService } from '../customer/customer.service';
import { ActivatedRoute, RouteReuseStrategy, Router } from '@angular/router';

@Component({
  selector: 'delete',
  templateUrl: './delete.component.html',
  styleUrl: './delete.component.css',
  providers: [CustomerService]
})
export class DeleteComponent implements OnInit {

  customerrec: any;
  customerid: any;
  constructor(private csvr: CustomerService,
    private art: ActivatedRoute,
    private rt: Router
  ) { }

  ngOnInit(): void {
    this.art.paramMap.subscribe(
      (data) => this.customerid = data.get('cid'),
      (err) => alert("Error" + JSON.stringify(err))
    );
    this.csvr.getCustomerById(this.customerid).subscribe(
      (data) => this.customerrec = data,
      (err) => alert("Error" + JSON.stringify(err))
    );
  }

  DeleteCustomer() {
    this.csvr.removeCustomer(this.customerid).subscribe(
      (data) => {
        alert("Record Deleted !!");
        this.rt.navigate(['\cust']);
      },
      (err) => alert(JSON.stringify(err))
    )
  }

}
