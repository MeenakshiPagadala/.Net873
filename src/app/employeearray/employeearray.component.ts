import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employeearray',
  templateUrl: './employeearray.component.html',
  styleUrls: ['./employeearray.component.css']
})
export class EmployeearrayComponent implements OnInit {

  people:any[]=[
    {"name":"sai","age":22,"dept":"hr"},
    {"name":"mukesh","age":23,"dept":"admin"},
    {"name":"bharat","age":24,"dept":"hr"},
    {"name":"karthik","age":22,"dept":"finance"}
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
