import { Component, OnInit } from "@angular/core";

import { LoginService } from "../services/login.service";

@Component({
    selector: "my-home",
    templateUrl: "home.component.html"
})
export class HomeComponent implements OnInit {
    isLogin = false;
    userName: string;

    constructor(
        private loginService: LoginService
    ) { }

    ngOnInit(): void {
        this.isLogin = this.loginService.checkLogin();
        if (this.isLogin) {
            this.loginService.getUserInfo().then(res => {
                this.userName = (res.Data as any).UserName;
            });
        }

    }
}