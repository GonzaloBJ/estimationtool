import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable } from '@angular/material/table';
import { IPartType } from 'src/app/models/IPartType';
import { TypesListDataSource } from './types-list-datasource';

@Component({
  selector: 'app-types-list',
  templateUrl: './types-list.component.html',
  styleUrls: ['./types-list.component.scss']
})
export class TypesListComponent implements AfterViewInit, OnInit {
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatTable) table: MatTable<IPartType>;
  dataSource: TypesListDataSource;

  /** Columns displayed in the table. Columns IDs can be added, removed, or reordered. */
  displayedColumns = ['id', 'name'];

  type: IPartType;

  formAppear = true;

  ngOnInit() {
    this.dataSource = new TypesListDataSource();
  }

  ngAfterViewInit() {
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
    this.table.dataSource = this.dataSource;
  }

  addNew(): void {
    this.type = {
      id : 4,
      name : 'ejemplo'
    };

    this.dataSource.data.push(this.type);

    this.table.dataSource = this.dataSource;

    this.table.renderRows();
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
  }

}
