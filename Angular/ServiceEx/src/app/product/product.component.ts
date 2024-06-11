import { Component, OnInit } from '@angular/core';
import { ProductService } from './product.service';
import { JSDocComment } from '@angular/compiler';
import { IProduct } from './iproduct';

@Component({
  selector: 'prod',
  templateUrl: './product.component.html',
  styleUrl: './product.component.css',
  providers: [ProductService]
})

export class ProductComponent implements OnInit {
  prods: IProduct[] = [];
  ngOnInit(): void {
    this.prodsvr.getAllProducts().subscribe(
      (data) => {
        alert(JSON.stringify(data));
        this.prods = data;
      },
      (err) => alert("Error" + JSON.stringify(err))
    );
  }
  constructor(private prodsvr: ProductService) { }
}
