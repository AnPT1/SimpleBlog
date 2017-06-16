import { Component } from "@angular/core";
import { Router } from '@angular/router';

import { LoginService } from "../services/login.service";

@Component({
    selector: 'login',
    templateUrl: './login.component.html',
    providers: [LoginService]
})
export class LoginComponent {
    private userName: string;
    private password: string;

    constructor(
        private loginService: LoginService,
        private router: Router
    ) { }

    login() {
        this.loginService.login(this.userName, this.password)
            .then(result => {
                if (result.State == 1) {
                    this.router.navigate(["./home"]);
                }
                else {
                    alert(result.Msg);
                }
            });
    }
}
