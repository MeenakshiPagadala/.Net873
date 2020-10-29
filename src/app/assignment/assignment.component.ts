import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-assignment',
  templateUrl: './assignment.component.html',
  styleUrls: ['./assignment.component.css']
})
export class AssignmentComponent implements OnInit {

  student:any[]=[
    {"ID":101,"Name":"Pramod","SemesterStatus":"True","img":"assets/images/womanface.jpe"},
    {"ID":102,"Name":"Rahul","SemesterStatus":"True","img":"assets/images/womanface.jpe"},
    {"ID":103,"Name":"Akshith","SemesterStatus":"True","img":"assets/images/womanface.jpe"},
    {"ID":104,"Name":"Abdul","SemesterStatus":"False","img":"assets/images/womanface.jpe"},
    {"ID":105,"Name":"Kalyan","SemesterStatus":"False","img":"assets/images/womanface.jpe"},
    {"ID":106,"Name":"Paul","SemesterStatus":"True","img":"assets/images/womanface.jpe"},
    {"ID":107,"Name":"Vijay","SemesterStatus":"False","img":"assets/images/womanface.jpe"},
    {"ID":108,"Name":"Geya","SemesterStatus":"False","img":"assets/images/womanface.jpe"},
    {"ID":109,"Name":"Meghana","SemesterStatus":"True","img":"assets/images/womanface.jpe"},
    {"ID":110,"Name":"Deepa","SemesterStatus":"False","img":"assets/images/womanface.jpe"},
  ];

 
  constructor() { }

  ngOnInit(): void {
  }

}
