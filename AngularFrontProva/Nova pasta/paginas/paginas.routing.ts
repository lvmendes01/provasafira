import { Routes } from '@angular/router';
import { PreviewComponent } from './preview/preview.component';


export const PaginasRoutes: Routes = [{
    path: '',
    children: [ {
        path: 'preview',
        component: PreviewComponent
    }]
}];
