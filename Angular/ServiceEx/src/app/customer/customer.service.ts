import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Icustomer } from './icustomer';
import { observableToBeFn } from 'rxjs/internal/testing/TestScheduler';

@Injectable()
export class CustomerService {

  url: string = "http://localhost:5144/api/CustomerAPI";

  constructor(private http: HttpClient) { }

  getAllCustomers(): Observable<Icustomer[]> {
    return this.http.get<Icustomer[]>(this.url);
  }

  createCustomer(rec: Icustomer): Observable<any> {
    return this.http.post(this.url, rec, { responseType: 'text' });
  }

  getCustomerById(cid: number): Observable<Icustomer> {
    return this.http.get<Icustomer>(this.url + "/" + cid);
  }


  modifyCustomer(rec: Icustomer): Observable<any> {
    return this.http.put(this.url, rec, { responseType: 'text' });
  }

  removeCustomer(cid: number): Observable<any> {
    return this.http.delete(this.url + "/" + cid, { responseType: 'text' });
  }
}
