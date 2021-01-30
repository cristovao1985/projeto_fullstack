
import { Injectable, EventEmitter } from '@angular/core';
import { Router } from '@angular/router';
import { User } from '../models/User';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private authUrl = "https://dev.sitemercado.com.br/api/";
  private isUserAuthenticated: boolean = false;


  public showMenuEmitter: EventEmitter<boolean> = new EventEmitter<boolean>();
  constructor(private router: Router) { }


  async login(user: User) {

    const code = btoa(`${user.Username}:${user.Password}`);

    await fetch(`${this.authUrl}/login`, {
      method: "POST",
      headers: {
        'Authorization': `Basic ${code}`,
      },

    }).then(async res => {
      const result = await res.json();
      this.isUserAuthenticated = result.success
      if (result.success) {
        this.showMenuEmitter.emit(true);
        (this.router.navigate(['/home']))

      } else {
        this.showMenuEmitter.emit(false);

      }

    }).catch(erro => {
      this.showMenuEmitter.emit(false);

    })


  }

  userAuthenticated(): boolean {
    return this.isUserAuthenticated;
  }
}
