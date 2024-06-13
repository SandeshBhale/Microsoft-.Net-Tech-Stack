import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'details',
  templateUrl: './details.component.html',
  styleUrl: './details.component.css'
})
export class DetailsComponent implements OnInit {

  customername: any;
  customerid: any;

  constructor(private art: ActivatedRoute) { }

  ngOnInit(): void {
    this.art.paramMap.subscribe(
      (data) => {
        this.customerid = data.get('cid');
        this.customername = data.get('cname');
      },
      (err) => alert("Error:" + err)
    )
  }
}
