import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../services/employee.service';
import { Employee } from '../model/employee.model';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrl: './employee-list.component.css'
})
export class EmployeeListComponent implements OnInit{
  employees?: Employee[];
  employee = {id:''};

  constructor(private employeeService: EmployeeService) {
      
   }
   ngOnInit(): void {
    this.loadEmployees(); // Load all employees on component load
  }

  onFormSubmit(form: NgForm) {
    this.loadEmployeesById(); //Load employee by ID on form submit
  }

  private loadEmployees() {
    this.employeeService.getEmployees().subscribe({
      next: (response) => {
        this.employees = response;
      },
      error: (error) => { //If an error occurs, log it to the console and set the employees array to an empty array
        console.error('Error fetching employees:', error);
        this.employees = [];
      }
    });
  }

  private loadEmployeesById() {
    console.log('Loading employee by ID:', this.employee.id);
    var temp_id = parseInt(this.employee.id);
    this.employeeService.getEmployeeById(temp_id).subscribe({
      
      next: (response) => {
        this.employees = response;
      },
      error: (error) => {
        console.error(`Error fetching employee with ID ${this.employee.id}:`, error);
        this.employees = []; 
      }
    });
  }

}
