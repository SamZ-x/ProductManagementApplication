import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  baseUrl = 'https://localhost:7088/api/';

  constructor(private http: HttpClient) { }

  public login(model: any) {
    return this.http.post(this.baseUrl + 'account/login', model).pipe(
      map((response: any) => {
        const user: any = response;
        if (user) {
          localStorage.setItem('user', JSON.stringify(user))
        }
      })
    );  //return observable(subscribe or to promise)
  }

  public logout () {
    localStorage.removeItem('user')
  }
}
