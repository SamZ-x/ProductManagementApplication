import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminRoutingModule } from './admin-routing.module';
import { RegisterComponent } from './component/register/register.component';
import { LoginComponent } from './component/login/login.component';
import { SharedModule } from "../shared/shared.module";
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';


@NgModule({
    declarations: [
        RegisterComponent,
        LoginComponent
    ],
    exports: [
        RegisterComponent
    ],
    imports: [
        CommonModule,
        HttpClientModule,
        AdminRoutingModule,
        SharedModule,
        FormsModule,
        HttpClientModule,
        BrowserAnimationsModule,
        MatSlideToggleModule,
    ]
})
export class AdminModule { }
