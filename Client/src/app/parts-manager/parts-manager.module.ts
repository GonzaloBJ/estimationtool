import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PartsManagerComponent } from './parts-manager.component';
import { MatTabsModule } from '@angular/material/tabs';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatTableModule } from '@angular/material/table';
import { PartsListComponent } from './parts-list/parts-list.component';
import { MatSortModule } from '@angular/material/sort';

import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatToolbarModule } from '@angular/material/toolbar';
import { TypesListComponent } from './types-list/types-list.component';
import { MatTooltipModule } from '@angular/material/tooltip';

@NgModule({
  declarations: [
    PartsManagerComponent,
    PartsListComponent,
    TypesListComponent,
  ],
  imports: [
    CommonModule,
    MatTabsModule,
    MatPaginatorModule,
    MatTableModule,
    MatSortModule,
    MatCardModule,
    MatIconModule,
    MatButtonModule,
    MatToolbarModule,
    MatTooltipModule
  ],
  exports: [
    PartsManagerComponent
  ]
})
export class PartsManagerModule { }
