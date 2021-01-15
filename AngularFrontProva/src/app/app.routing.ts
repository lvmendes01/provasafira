import { Routes } from '@angular/router';
import { LoginComponent } from './pages/login/login.component';

export const AppRoutes: Routes = [
     
    {
            path: '',
            component: LoginComponent,
          
        },
        {
            path: 'inicio',
            loadChildren: './components/components.module#ComponentsModule'
          
        },

       
        
];
