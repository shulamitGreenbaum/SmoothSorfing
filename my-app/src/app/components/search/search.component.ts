import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators, FormBuilder, FormArray } from '@angular/forms';
import{VoiceRecognitionService} from '../../shared/services/voice-recorder.service'


@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.scss']
})
export class SearchComponent implements OnInit {
  searchMacroForm!:FormGroup
  SText:string | undefined
  allSen:string[] =[];
  companyForm = this.fb.group({
    companyName: new FormControl('', [Validators.required]),
    admins: this.fb.array([])

    
  })
  constructor(private fb: FormBuilder,private voiceRecognitionService : VoiceRecognitionService) { 
    
  }
  get admins() {
    return this.companyForm.controls["admins"] as FormArray;
  }
 
  ngOnInit(): void {
    this.searchMacroForm=new FormGroup({
      searchMacro:new FormControl('',Validators.required), 
    })
    this.voiceRecognitionService.init()

  }
   recordingInProgress=-1;
  start(): void{
    this.recordingInProgress*=-1;
   if(this.recordingInProgress>0)
     this.voiceRecognitionService.start();
    else 
     this.voiceRecognitionService.stop();
  }

  saveText( text:string): void{
   this.SText = text;
   this.voiceRecognitionService.saveText(this.SText).subscribe(
    (     res: any)=>(this.allSen.push(res))
   
    );
  }

}
