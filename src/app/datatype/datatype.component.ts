import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-datatype',
  templateUrl: './datatype.component.html',
  styleUrls: ['./datatype.component.css']
})
export class DatatypeComponent implements OnInit {
  name:string="shiva";
  age:number;
  hobbies:string[];
  marks:Array<number>;
  istrue:boolean;
  student:object;
  tupleval:[string,number,boolean];
  dynamicvalue:any;

  picture="assets/images/insecttrap.jpg";

  constructor() {
    this.age=25;
    this.hobbies=["reading","piano"];
    this.marks=[89,90,78];
    this.istrue=false;
    this.tupleval=["Murugan",25,true];
    this.student={fathername:"kumar",city:"chennai"};
    this.dynamicvalue="hi";
    this.dynamicvalue=true;
   }

  ngOnInit(): void {
  }

}
