import { Injectable } from '@angular/core';
import { IProduct } from './iproduct';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class ProductService {
  url: string = "http://localhost:5105/api/productapi"

  constructor(private http: HttpClient) { }

  getAllProducts(): Observable<IProduct[]> {
    return this.http.get<IProduct[]>(this.url);
  }
}
