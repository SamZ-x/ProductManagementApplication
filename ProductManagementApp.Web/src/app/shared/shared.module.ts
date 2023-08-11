import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SharedRoutingModule } from './shared-routing.module';
import { NavComponent } from './component/nav/nav.component';
import { PageNotFoundComponent } from './component/page-not-found/page-not-found.component';


@NgModule({
  declarations: [
    NavComponent,
    PageNotFoundComponent
  ],
  imports: [
    CommonModule,
    SharedRoutingModule
  ],
  exports: [
    NavComponent,
    PageNotFoundComponent
  ]
})
export class SharedModule { }
