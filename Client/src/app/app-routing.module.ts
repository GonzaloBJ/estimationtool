import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { PartsManagerComponent } from './parts-manager/parts-manager.component';

const routes: Routes = [
  {path: '', component: DashboardComponent},
  {path: 'partsmanager', component: PartsManagerComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
