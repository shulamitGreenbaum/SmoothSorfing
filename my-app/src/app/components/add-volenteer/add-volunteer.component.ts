import { Component, OnInit } from '@angular/core';
import { Volunteer } from 'src/app/shared/models/volunteer.model';
import { VolunteerService } from 'src/app/shared/services/volunteer.service';

@Component({
  selector: 'app-add-volunteer',
  templateUrl: './add-volunteer.component.html',
  styleUrls: ['./add-volunteer.component.scss']
})
export class AddVolunteerComponent implements OnInit {
volunteer:Volunteer=new Volunteer();
  
 
  constructor(private volunteerService:VolunteerService ) { }

  ngOnInit(): void {
    this.volunteer.name="aa";
    this.volunteer.password="123"
    this.volunteer.emailAddress="123@gmail.com"
    this.addVolunteer();
    this.volunteerService.getVolunteer().subscribe(
      (      res: any)=>console.log('current volunteer '+this.volunteer),
      (      err: any)=>console.error(err),
    )
  }
  addVolunteer(){
    this.volunteerService.addVolunteer(this.volunteer).subscribe(
      (    res: any)=>{console.log(res)},
      (    err: any)=>{console.log(err)}
    )
  }

}
