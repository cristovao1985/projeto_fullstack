import { Component, OnInit } from '@angular/core';
import { AuthService } from 'src/app/auth/auth.service';
import { User } from 'src/app/models/User';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  user: User = new User();
  loginSuccessfull!: boolean;
  constructor(private _authService: AuthService) { }

  ngOnInit(): void {
  }
  async login() {
    await this._authService.login(this.user);
    this.loginSuccessfull = this._authService.userAuthenticated();



  }


}
