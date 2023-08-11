import { Component } from '@angular/core';
import { AccountService } from 'src/app/services/account.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {

  model: any = {};
  loggedIn: boolean =false;
  
  /**
   *
   */
  constructor(private accountService: AccountService) {
  
  }

  login() {
    console.log(this.model);
    this.accountService.login(this.model).subscribe({
      next: response => {
        console.log(response);
      },
      error: error=>console.log(error)});
    }
}
