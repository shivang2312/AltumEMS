import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeService } from './employee.service';
import { IEmployee, Employee, Department } from './employee';

@Component({
  selector: 'app-employee-form',
  templateUrl: './employee-form.component.html',
  styleUrls: ['./employee-form.component.css']
})
export class EmployeeFormComponent implements OnInit {

  employeeData:Employee = new Employee() ;
  keys : number[];
  departments=Department;

  constructor(private route : ActivatedRoute, private employeeService : EmployeeService
    ,private router : Router) { 
      this.keys = Object.keys(this.departments).filter(f => !isNaN(Number(f))).map(function(v) {
        return parseInt(v, 10)});
    }

  ngOnInit() {
    
    let id = +this.route.snapshot.paramMap.get('id');
    if(id!=0)
    {
      this.employeeService.getEmployeeById(id).subscribe({
        next : employeeData => this.employeeData=employeeData
      });
    }
  }

  updateEmployee(){
    if(this.employeeData.id!=0)
    {
      debugger;
    this.employeeService.updateEmployee(this.employeeData).subscribe(
      {
        next :data=> 
        {
          alert("Employee Updated");
          this.router.navigate([''])
        }
      });
    }
    else if(this.employeeData.id==0)
    {
      this.employeeService.addEmployee(this.employeeData).subscribe(
        {
          next :data=> 
          {
            alert("Employee Added");
            this.router.navigate([''])
          }
        });
    }
  }

  getDepartmentName(deptId : Department) : string
    {
        return Department[deptId];
    }

}
