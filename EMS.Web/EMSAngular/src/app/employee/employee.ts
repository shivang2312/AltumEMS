export interface IEmployee
{
    id : number;
    firstName : string;
    lastName : string;
    department : Department;
    salary : number;
}

export class Employee implements IEmployee
{
    id : number =0;
    firstName : string =null;
    lastName : string =null;
    department : Department;
    salary : number = 0;
}

export enum Department
{
    Admin,
    Marketing,
    Development,
    Finance,
    HR
}