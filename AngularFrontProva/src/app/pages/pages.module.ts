
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { PagesRoutes } from './pages.routing';

import { LoginComponent } from './login/login.component';
import { NgModule } from '@angular/core';
@NgModule({
    imports: [
        CommonModule,
        RouterModule.forChild(PagesRoutes),
        FormsModule,
        FormsModule
    ],
    declarations: [
        LoginComponent,
    ]
})

export class PagesModule {}
