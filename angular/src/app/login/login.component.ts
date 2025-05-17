// import { Component } from '@angular/core';
// import { CommonModule } from '@angular/common';
// import { FormsModule } from '@angular/forms';
// import { HttpClient } from '@angular/common/http';
// import { Router } from '@angular/router';

// @Component({
//   standalone: true,
//   selector: 'app-login',
//   imports: [CommonModule, FormsModule],
//   templateUrl: './login.component.html',
// })
// export class LoginComponent {
//   username = '';
//   password = '';
//   loading = false;
//   error = '';

//   constructor(private http: HttpClient, private router: Router) { }

//   login() {
//     this.loading = true;
//     this.error = '';

//     const body = new URLSearchParams({
//       grant_type: 'password',
//       username: this.username,
//       password: this.password,
//       client_id: 'MoftiSolution_App',
//       scope: 'offline_access MyApp role email phone address openid profile',
//     });

//     this.http
//       .post<any>('https://localhost:44392/connect/token', body.toString(), {
//         headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
//       })
//       .subscribe({
//         next: (res) => {
//           localStorage.setItem('access_token', res.access_token);
//           this.router.navigateByUrl('/');
//         },
//         error: () => {
//           this.error = 'خطأ في اسم المستخدم أو كلمة المرور';
//           this.loading = false;
//         },
//       });
//   }
// }

import { CommonModule } from '@angular/common';
import { HttpParams, HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router } from '@angular/router'; // كمان ضروري إذا ما ضفته
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  imports: [CommonModule, FormsModule, ReactiveFormsModule],
})
export class LoginComponent {
  loginForm: FormGroup;

  constructor(private fb: FormBuilder,
    private http: HttpClient,
    private router: Router) {
    this.loginForm = this.fb.group({
      userName: ['', Validators.required],
      password: ['', Validators.required]
    });
  }

  onSubmit() {
    if (this.loginForm.valid) {
      const formData = new HttpParams()
        .set('grant_type', 'password')
        .set('client_id', 'MoftiSolution_App') // تأكد من نفس القيمة في appsettings
        .set('username', this.loginForm.value.userName)
        .set('password', this.loginForm.value.password)
        .set('scope', 'role email phone address MoftiSolution openid profile');

      this.http.post<any>('https://localhost:44392/connect/token', formData.toString(), {
        headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
      }).subscribe({
        next: (res) => {
          console.log('Login Success:', res);

          // 🛡️ نحفظ التوكن في localStorage (أو sessionStorage)
          localStorage.setItem('access_token', res.access_token);

          // 🔁 إعادة التوجيه مثلاً لصفحة الـ dashboard
          this.router.navigateByUrl('/dashboard');
        },
        error: (err) => {
          console.error('Login Error:', err);
          alert('فشل تسجيل الدخول، تأكد من البيانات');
        }
      });
    }
  }

}
