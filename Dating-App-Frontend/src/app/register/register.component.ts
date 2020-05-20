import { AlertifyService } from "./../_services/alertify.service";
import { Component, OnInit, Input, Output, EventEmitter } from "@angular/core";
import { AuthService } from "../_services/auth.service";

@Component({
  selector: "app-register",
  templateUrl: "./register.component.html",
  styleUrls: ["./register.component.css"],
})
export class RegisterComponent implements OnInit {
  @Output() cancelRegister = new EventEmitter();
  model: any = {};

  constructor(
    private authService: AuthService,
    private aleritfy: AlertifyService
  ) {}

  ngOnInit() {}

  register() {
    this.authService.register(this.model).subscribe(
      () => {
        this.aleritfy.success("registration successful");
      },
      (error) => {
        this.aleritfy.error(error);
      }
    );
  }

  cancel() {
    this.cancelRegister.emit(false);
    this.aleritfy.message("cancelled");
  }
}
