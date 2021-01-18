import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { PaginasRoutes } from './paginas.routing';
import { PreviewComponent } from './preview/preview.component';



@NgModule({
    imports: [
        CommonModule,
        RouterModule.forChild(PaginasRoutes),
        FormsModule,
        FormsModule
    ],
    declarations: [
        PreviewComponent,
    ]
})

export class PaginasModule {}
