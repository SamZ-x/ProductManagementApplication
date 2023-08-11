import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './main/home/home.component';
import { RegisterComponent } from './admin/component/register/register.component';
import { PageNotFoundComponent } from './shared/component/page-not-found/page-not-found.component';
import { LoginComponent } from './admin/component/login/login.component';

const routes: Routes = [
  { path: 'main', component: HomeComponent },
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: '',   redirectTo: '/login', pathMatch: 'full' },
  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
