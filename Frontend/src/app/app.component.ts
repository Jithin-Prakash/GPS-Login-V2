import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { AuthService } from './services/auth.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})


export class AppComponent implements OnInit{
  constructor() {}
  //constructor(private loginAuth: AuthService) {}
  ngOnInit(): void {
    
  }
  
  title="Login";

  loginForm = new FormGroup({
    username: new FormControl(""),
    password: new FormControl("")
  })
  
  

  isUserValid: boolean = false;

  loginSubmitted(){
    // this.loginAuth.loginUser([this.loginForm.value.username!, this.loginForm.value.password!]).subscribe(res => {
    //   if(res == "Unsuccessful"){
    //     this.isUserValid = false;
    //     alert("Login Unsuccessful");
    //   }else{
    //     this.isUserValid = true;
    //     alert("Login Successful");
    //   }
    //   alert("HI");
    // });
    console.log(this.loginForm);
    
  }

  get Username(): FormControl {
    return this.loginForm.get("username") as FormControl;
  }
  
  get Password(): FormControl {
    return this.loginForm.get("password") as FormControl;
  }
}
