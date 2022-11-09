import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-rate-video',
  templateUrl: './rate-video.component.html',
  styleUrls: ['./rate-video.component.scss']
})
export class RateVideoComponent implements OnInit {
 // allRatings;
  constructor(private router: ActivatedRoute) {
  //  const bestPro = parseInt(this.router.snapshot.paramMap.get('rating'));
  //  let db = new DB();
  //  this.allRatings = db.allProfessionals.filter(p => p.rating == bestPro);
  }
 // constructor() { }

  ngOnInit(): void {
  }

}
