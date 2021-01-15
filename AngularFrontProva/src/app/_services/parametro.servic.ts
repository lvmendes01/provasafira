import { HttpHeaders } from '@angular/common/http';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map, catchError } from 'rxjs/operators';
import { Injectable } from '@angular/core';
import { environment } from 'environments/environment';
import { Lojas } from 'app/_models/lojas';
import { Parametro } from 'app/_models/parametro';



export const httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  };


@Injectable({ providedIn: 'root' })
export class ParametroService {

    constructor(private http: HttpClient) { }

    ListaParametroDefault() :Observable<any>{
        var json = "";  
    return this.http.post(environment.apiConfiguracao +'/Parametro/ListaParametroDefault', json,{ headers: httpOptions.headers}
    ) .pipe(map((res: any) => {
        if( res.resultado){
          return  res.valor;
        }
        return null;
      }));    

    }


    AtualizarParametro(parametro: Parametro) :Observable<any>{
      var json = JSON.stringify(parametro);
  return this.http.post(environment.apiConfiguracao +'/Parametro/AtualizarParametro', json,{ headers: httpOptions.headers}
  ) .pipe(map((res: any) => {
      if( res.resultado){
        return  res.valor;
      }
      return null;
    }));    

  }


}