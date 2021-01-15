import { Routes } from '@angular/router';
import { PreviewComponent } from 'app/_services/components/preview/preview.component';

import { LoginComponent } from './login/login.component';

export const PagesRoutes: Routes = [{
    path: '',
    children: [ {
        path: 'login',
        component: LoginComponent
    },{
        path: 'home',
        component: PreviewComponent
    }]
}];
