import { Component, OnInit } from '@angular/core';
import {ThemePalette} from '@angular/material/core';

@Component({
  selector: 'app-parts-manager',
  templateUrl: './parts-manager.component.html',
  styleUrls: ['./parts-manager.component.scss']
})
export class PartsManagerComponent implements OnInit {

  links = ['Parts Manager', 'Types Manager'];
  activeLink = this.links[0];
  background: ThemePalette = 'primary';

  constructor() { }

  ngOnInit(): void {
  }

}
