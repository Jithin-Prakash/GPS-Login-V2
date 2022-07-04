import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  constructor(private http: HttpClient) {}

  baseServerUrl = "http://localhost:7149/User/"

  loginUser(loginInfo: Array<string>){
    return this.http.post(this.baseServerUrl+'login', {
      username: loginInfo[0],
      password: loginInfo[1]
    },
    {
      responseType: 'text'
    })
  }
  
  
}
