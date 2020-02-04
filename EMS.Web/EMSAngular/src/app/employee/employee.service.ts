import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders,HttpParams} from '@angular/common/http';
import {IEmployee, Employee} from './employee';
import { Observable } from 'rxjs';
import { JsonPipe } from '@angular/common';
import { debug } from 'util';

@Injectable({
    providedIn : 'root'
})

export class EmployeeService
{
    url='https://localhost:44388/employee';
    headers = new HttpHeaders({'Content-Type': 'application/json'});

    constructor(private http : HttpClient)
    {

    }

    getAllEmployees() : Observable<IEmployee[]>
    {
        return this.http.get<IEmployee[]>(this.url);
    }

    getEmployeeById(id : number) : Observable<IEmployee>
    {
        return this.http.get<IEmployee>(this.url+"/"+id);
    }

    deleteEmployee(id : number) : Observable<boolean>
    {
        return this.http.delete<boolean>(this.url+"/"+id);
    }

    updateEmployee(updatedEmployee : IEmployee) : Observable<IEmployee>
    {
        return this.http.put<IEmployee>(this.url,JSON.stringify(updatedEmployee),{headers:this.headers});
    }

    addEmployee(newEmployee : Employee) : Observable<IEmployee>
    {
        return this.http.post<IEmployee>(this.url,JSON.stringify(newEmployee),{headers:this.headers});
    }
}