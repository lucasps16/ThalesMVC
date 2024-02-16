import { Injectable } from '@angular/core';
import { Employee } from '../model/employee.model';
import { Observable, catchError, map, of } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private http: HttpClient) { }

  getEmployees(): Observable<Employee[]> {
    return this.http.get<Employee[]>(`${environment.apiBaseUrl}/employees`)
  }

  getEmployeeById(id: number): Observable<Employee[]> {
    return this.http.get<Employee>(`${environment.apiBaseUrl}/employees/${id}`).pipe(
      map((employee: Employee) => [employee]), // Convert the single employee to an array
      catchError((error: any) => {
        console.error('Error fetching employee by ID:', error);
        return of([]); // Return an empty array in case of an error
      })
    );
    
  }
}
