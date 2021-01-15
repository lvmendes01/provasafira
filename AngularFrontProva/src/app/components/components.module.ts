import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { PreviewComponent } from './preview/preview.component';
import { ComponentsRoutes } from './components.routing';
import { LojaService } from 'app/_services/lojas.service';
import { TipoParametroService } from 'app/_services/tipoParametro.service';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { JwBootstrapSwitchNg2Module } from 'jw-bootstrap-switch-ng2';
import { TagInputModule } from 'ngx-chips';
import { ParametroService } from 'app/_services/parametro.servic';
import { NgxBootstrapSliderModule } from 'ngx-bootstrap-slider';
import { Ng5SliderModule } from 'ng5-slider';


@NgModule({
    imports: [
        CommonModule,
        RouterModule.forChild(ComponentsRoutes),
        FormsModule,
        TagInputModule,
        JwBootstrapSwitchNg2Module,
        NgbModule,
        NgxBootstrapSliderModule,
        Ng5SliderModule
         
    ],
    declarations: [
        PreviewComponent,
    ],
    providers:[
        LojaService,
        TipoParametroService,
        ParametroService
    ]
})

export class ComponentsModule {}
