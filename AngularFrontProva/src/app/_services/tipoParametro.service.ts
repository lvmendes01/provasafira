import { HttpHeaders } from '@angular/common/http';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map, catchError } from 'rxjs/operators';
import { Injectable } from '@angular/core';
import { environment } from 'environments/environment';
import { Lojas } from 'app/_models/lojas';



export const httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  };


@Injectable({ providedIn: 'root' })
export class TipoParametroService {





    constructor(private http: HttpClient) { }

    ListarTipos() :Observable<any>{
        var json = "";  
    return this.http.post(environment.apiConfiguracao +'/ListaTipoParametro', json,{ headers: httpOptions.headers}
    ) .pipe(map((res: any) => {
        if( res.resultado){
          return  res.valor;
        }
        return null;
      }));    

    }
}