import { Component, OnInit } from '@angular/core';
import { CustomerService } from '../customer/customer.service';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder } from '@angular/forms';
import { AnimateTimings } from '@angular/animations';

@Component({
  selector: 'edit',
  templateUrl: './edit.component.html',
  styleUrl: './edit.component.css',
  providers: [CustomerService]
})
export class EditComponent implements OnInit {

  customerId: any;
  cfrm: any;

  constructor(private art: ActivatedRoute, private csvr: CustomerService, private fb: FormBuilder, private rt: Router) { }

  ngOnInit(): void {
    this.art.paramMap.subscribe(
      (data) => this.customerId = data.get('cid'),
      (err) => alert("Error" + JSON.stringify(err))
    );

    this.cfrm = this.fb.group(
      {
        customerID: [],
        customerName: [],
        address: [],
        emailID: [],
        mobileNo: [],
        creditLimit: []
      }
    );

    this.csvr.getCustomerById(this.customerId)
      .subscribe(
        (data) => {
          this.cfrm.patchValue(data)
        },
        (err) => alert("Error : " + JSON.stringify(err))
      );
  }


  UpdateCustomer(): void {
    this.csvr.modifyCustomer(this.cfrm.value).subscribe(
      (data) => {
        alert("Customer Updated !");
        this.rt.navigate(['/cust'])
      },
      (err) => alert("Error" + JSON.stringify(err))
    );
  }
}
