import { Component} from '@angular/core';
import { UserService } from 'src/app/services/user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent {

  constructor(private router: Router,public userService: UserService) { }

  Logout() {
    this.userService.Logout();
    this.router.navigate(["/"]);
  }

}
