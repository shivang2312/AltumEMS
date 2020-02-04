import { Component, OnInit } from '@angular/core';
import { IEmployee,Department } from './employee';
import { EmployeeService } from './employee.service';
import { NotExpr } from '@angular/compiler';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  pageTitle = "Employee List";
  employees : IEmployee[];
  result : boolean;
  department:string;

  constructor(private employeeService : EmployeeService) { 
  }

  ngOnInit() {
    this.employeeService.getAllEmployees().subscribe({
      next : employees => this.employees=employees
      });
    }

    getDepartmentName(deptId : Department) : string
    {
        return Department[deptId];
    }

  deleteEmployee(id : number, name : string)
  {
    if(confirm("Are you sure to delete "+name +"'s records?")){
    this.employeeService.deleteEmployee(id).subscribe(
      next => 
      {
        result => this.result=result;
        
        this.ngOnInit();
        
      }
    );
  }
}

}
