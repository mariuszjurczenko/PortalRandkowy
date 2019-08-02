import { Component, OnInit, Input } from '@angular/core';
import { Photo } from '../../_models/photo';

@Component({
  selector: 'app-photos',
  templateUrl: './photos.component.html',
  styleUrls: ['./photos.component.css']
})
export class PhotosComponent implements OnInit {

  @Input() photos: Photo[];

  constructor() { }

  ngOnInit() {
  }

}
