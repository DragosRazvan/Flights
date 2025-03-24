import { Component } from '@angular/core';
import { ApiService } from '../api.service';

@Component({
  selector: 'app-search-flights',
  standalone: false,
  templateUrl: './search-flights.component.html',
  styleUrl: './search-flights.component.css'
})
export class SearchFlightsComponent {
  searchResult: FlightRm[] = [
    {
      airline: "American Airlines",
      remainingNumberOfSeats: 500,
      departure: { time: Date.now().toString(), place: "Los Angeles" },
      arrival: { time: Date.now().toString(), place: "Istanbul" },
      price: "350",
    },
    {
      airline: "Turkish Airlines",
      remainingNumberOfSeats: 140,
      departure: { time: Date.now().toString(), place: "Bangalore" },
      arrival: { time: Date.now().toString(), place: "Istanbul" },
      price: "176",
    },
    {
      airline: "Lufthansa",
      remainingNumberOfSeats: 76,
      departure: { time: Date.now().toString(), place: "Munchen" },
      arrival: { time: Date.now().toString(), place: "Sibiu" },
      price: "200",
    },
    {
      airline: "Qatar Airways",
      remainingNumberOfSeats: 200,
      departure: { time: Date.now().toString(), place: "Dubai" },
      arrival: { time: Date.now().toString(), place: "London" },
      price: "250",
    }
  ]

  data: any;

  constructor(private apiService: ApiService) { }

  ngOnInit() {
    this.apiService.getData().subscribe(response => {
      this.data = response;
      console.log(this.data);
    }, error => {
      console.error('Error fetching data:', error);
    });
}
}

export interface FlightRm {
  airline: string;
  arrival: TimePlaceRm;
  departure: TimePlaceRm;
  price: string;
  remainingNumberOfSeats: number;
}

export interface TimePlaceRm {
  place: string;
  time: string;
}
