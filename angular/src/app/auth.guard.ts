
import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private router: Router) { }

  canActivate(): boolean {
    const token = localStorage.getItem('access_token');

    if (!token) {
      console.log('No token found, redirecting to login');
      this.router.navigate(['/login']);
      return false;
    }

    return true;
  }
}
