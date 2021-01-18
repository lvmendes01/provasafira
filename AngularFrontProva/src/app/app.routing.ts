import { Routes } from '@angular/router';
import { ArtistasComponent } from './artistas/artistas.component';
import { LoginComponent } from './login/login.component';
import { AuthGuard } from './_helpers/auth.guard';

export const AppRoutes: Routes = [
    
    { path: 'artista', component: ArtistasComponent, canActivate: [AuthGuard] },
    { path: '', component: LoginComponent },
    // otherwise redirect to home
    { path: '**', redirectTo: '' }

        
];
