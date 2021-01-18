import {Component, ViewChild, ElementRef} from '@angular/core';
import {DecimalPipe} from '@angular/common';
import { NouiFormatter } from "ng2-nouislider";


@Component({
  selector: 'app-sliders',
  templateUrl: './sliders.component.html',
  styleUrls: ['./sliders.component.css'],
  
  providers:[DecimalPipe],
})
export class SlidersComponent  {
  @ViewChild('slider', {read: ElementRef}) slider: ElementRef;

  sliderRange;

  someKeyboardConfig: any = {
    connect: true,
    start: [400, 500],
    step: 10,
    tooltips: [new TimeFormatter(this.decimalPipe), new TimeFormatter(this.decimalPipe)],
    range: {
      min: 360,
      max: 1080
    },
    behaviour: 'drag',
  };

  constructor(private decimalPipe: DecimalPipe) {};

  ngAfterViewInit() {
    this.func();
  }

  func() {
    const connect = this.slider.nativeElement.querySelectorAll('.noUi-connect');
    const classes = ['c-1-color', 'c-2-color', 'c-3-color'];
    console.log(connect.length);
    for (let i = 0; i < connect.length; i++) {
      connect[i].classList.add(classes[i]);
    }
  }
}

export class TimeFormatter implements NouiFormatter {
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
