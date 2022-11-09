import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { observableToBeFn } from 'rxjs/internal/testing/TestScheduler';
import { Observable } from 'rxjs/internal/Observable';
import { Volunteer } from '../models/volunteer.model';
@Injectable({
  providedIn: 'root'
})

export class VolunteerService {


  constructor(private http:HttpClient) { }

  addVolunteer(volunteer:Volunteer): Observable<boolean>{

   return this.http.post<boolean>(environment.url+'volunteer/AddVoLunteer',volunteer)
  }
  getVolunteer() :Observable<number>{

return this.http.get<number>(environment.url+'volunteer/getname')
  }
}
