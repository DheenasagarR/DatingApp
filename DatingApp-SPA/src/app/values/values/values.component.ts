import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-values',
  templateUrl: './values.component.html',
  styleUrls: ['./values.component.css'],
})
export class ValuesComponent implements OnInit {
  values: any;
  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getValues();
  }

  public getValues(): void {
    this.http.get('http://localhost:5055/api/values').subscribe(
      (response) => {
        this.values = response;
      },
      (error) => {
        console.log(error);
      }
    );
  }
}
