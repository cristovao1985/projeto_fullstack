import { Component } from '@angular/core';
import { AuthService } from './auth/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'client';
  showMenu: boolean = false

  constructor(private _authService: AuthService) {

  }

  ngOnInit() {
    this._authService.showMenuEmitter.subscribe((show: boolean) => this.showMenu = show)
  }
}
