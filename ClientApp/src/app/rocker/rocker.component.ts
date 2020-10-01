import { Component, OnInit, Inject } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-rocker',
  templateUrl: './rocker.component.html',
  styleUrls: ['./rocker.component.css']
})
export class RockerComponent implements OnInit {
  public rockers: Rocker[];
  public newRocker: Rocker = { firstName:'', lastName: '', instrument: '', isAlive: true };

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {

   }

   async ngOnInit(){
     this.rockers = await this.http.get<Rocker[]>(this.baseUrl + 'rocker').toPromise();
   }

   async save() {
    await this.http.post<Rocker[]>(this.baseUrl + 'rocker', this.newRocker).toPromise();
    this.newRocker = { firstName: '', lastName:'', instrument:'', isAlive: true };
    this.rockers = await this.http.get<Rocker[]>(this.baseUrl + 'rocker').toPromise();
}

  }
interface Rocker{
    firstName: string;
    lastName: string;
    instrument: string;
    isAlive: boolean;
  }



