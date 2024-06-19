import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IEmployee } from './iemployee';
import { Department } from './department';

@Injectable()
export class EmployeeService {

  url: string = "http://localhost:5284/api/EmployeeAPI";
  url1: string = "http://localhost:5284/api/DepartmentAPI";

  constructor(private http: HttpClient) { }

  getAllEmployees(): Observable<IEmployee[]> {
    return this.http.get<IEmployee[]>(this.url);
  }

  getAllDepartments(): Observable<Department[]> {
    return this.http.get<Department[]>(this.url1);
  }

  createEmp(rec: IEmployee): Observable<any> {
    return this.http.post(this.url, rec, { responseType: 'text' });
  }

  getById(eid: number): Observable<IEmployee> {
    return this.http.get<IEmployee>(this.url + "/" + eid);
  }

  modifyEmployee(rec: IEmployee): Observable<any> {
    alert(JSON.stringify(rec));
    return this.http.put(this.url, rec, { responseType: "text" });
  }

  removeEmployee(eid: number): Observable<any> {
    return this.http.delete(this.url + "/" + eid, { responseType: "text" })
  }
}
