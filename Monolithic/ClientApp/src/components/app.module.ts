import { Chart } from 'chart.js';
import { CacheService } from '../services/CacheService.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { ChartsModule } from 'ng2-charts/ng2-charts';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ApiService } from '../services/ApiService.service';
import { Ng5SliderModule } from 'ng5-slider';
import 'chartjs-plugin-zoom';
import { csvConvertorService } from '../services/csv.convertor.service';
import { SweetAlert2Module } from '@toverux/ngx-sweetalert2';
import { DataTablesModule } from 'angular-datatables';
import { sweetAlertService } from '../services/sweetAlertService.service';

import { DatePipe } from '@angular/common';
import { SideMenuComponent } from './Layot/sidebar-menu/sidebar.menu.component';
import { HeaderComponent } from './Layot/header-menu/header.component';
import { DashboardComponent } from './Pages/dashboard/dashboard.component';
import { PageNotFoundComponent } from './Pages/PageNotFoundComponent/page.not.found.component';



@NgModule({
  declarations: [
    AppComponent,
    SideMenuComponent,
    HeaderComponent,
    PageNotFoundComponent,
    DashboardComponent,

  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    BrowserModule,
    FormsModule,
    ChartsModule,
    NgbModule,
    Ng5SliderModule,
    RouterModule.forRoot([
      { path: '', component: DashboardComponent, pathMatch: 'full' },
      { path: '**', component: PageNotFoundComponent },
    ]),
    SweetAlert2Module.forRoot({
      buttonsStyling: false,
      customClass: 'modal-content',
      confirmButtonClass: 'btn btn-primary',
      cancelButtonClass: 'btn'
    })
    , DataTablesModule


  ],
  providers: [
    , DatePipe
    , ApiService
    , csvConvertorService
    , CacheService
    , sweetAlertService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
