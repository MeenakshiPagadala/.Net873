import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  people:any[]=[
    {"name":"sai","age":22,"dept":"HR"},
    {"name":"mukesh","age":23,"dept":"admin"},
    {"name":"bharat","age":24,"dept":"HR"},
    {"name":"karthik","age":22,"dept":"finance"},
    {"name":"sarada","age":26,"dept":"Sales"},
    {"name":"kushmanda","age":21,"dept":"development"},
  ];

}
