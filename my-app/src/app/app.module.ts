import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';
import { AppComponent } from './app.component';
import { AddVolunteerComponent } from './components/add-volenteer/add-volunteer.component';
import { SearchComponent } from './components/search/search.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { VeiwVideoComponent } from './components/veiw-video/veiw-video.component';
import { RateVideoComponent } from './components/rate-video/rate-video.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule, Routes } from '@angular/router';
import { ErrorComponent } from './components/error/error.component';
import { MaterialExampleModule } from './material.module';
import { seeMacroComponent } from './components/seeMacro/seeMacro.component';

const routes: Routes = [
  {path:'home', component:SearchComponent}, 
  {path: 'search', component:SearchComponent},
  {path:'',redirectTo:'home', pathMatch:'full'}, 
  {path: 'add-volunteer', component:AddVolunteerComponent},
  {path: 'rate-video', component:RateVideoComponent},
  {path: 'veiw-video', component:VeiwVideoComponent},
  {path: 'seeMacro', component:seeMacroComponent},
  {path:'**', component:ErrorComponent} //always has to be last
  ];




@NgModule({
  declarations: [
    AppComponent,
    AddVolunteerComponent,
    SearchComponent,
    RateVideoComponent,
    VeiwVideoComponent,
    ErrorComponent,
    seeMacroComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes),
    HttpClientModule,
    ReactiveFormsModule, 
    FormsModule, 
    BrowserAnimationsModule,
    MaterialExampleModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
