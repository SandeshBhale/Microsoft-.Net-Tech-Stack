import { Component, OnInit } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { CustomerService } from '../customer/customer.service';
import { Router } from '@angular/router';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { errorContext } from 'rxjs/internal/util/errorContext';
@Component({
  selector: 'create',
  templateUrl: './create.component.html',
  styleUrl: './create.component.css',
  providers: [CustomerService]
})
export class CreateComponent implements OnInit {

  cfrm: any;
  constructor(private custsvr: CustomerService
    , private rt: Router
  ) { }

  ngOnInit(): void {
    this.cfrm = new FormGroup({
      customerName: new FormControl(null, [Validators.required]),
      address: new FormControl(null, [Validators.required]),
      emailID: new FormControl(null, [Validators.required]),
      mobileNo: new FormControl(null, [Validators.required]),
      creditLimit: new FormControl(null, [Validators.required])
    })
  }

  SaveCustomer(): void {
    this.custsvr.createCustomer(this.cfrm.value).subscribe(
      (data) => {
        alert("Customer Created !");
        this.rt.navigate(['/cust']);
      },
      (err) => alert(JSON.stringify(err))
    )
  }

}
