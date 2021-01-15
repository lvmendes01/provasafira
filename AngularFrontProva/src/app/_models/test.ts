import { DecimalPipe } from "@angular/common";

export class RootObject {
    date: Date;
    temperatureC: number;
    temperatureF: number;
    summary: string;
}



export class TimeFormatter  {
    constructor(private decimalPipe: DecimalPipe) {};
  
    to(value: number): string {
      let h = Math.floor(value/60);
      let m = value%60;
      let output = this.decimalPipe.transform(h, '2.0') + ":" + this.decimalPipe.transform(m, '2.0');
      return output;
   }
  
    from(value: string): number {
      return Number(value.split(":")[0])*60+Number(value.split(":")[1]);
    }
  }