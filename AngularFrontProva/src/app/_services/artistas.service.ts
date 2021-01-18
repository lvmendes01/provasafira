import { HttpHeaders } from '@angular/common/http';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map, catchError } from 'rxjs/operators';
import { Injectable } from '@angular/core';
import { environment } from 'environments/environment';



export const httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
      "Authorization": 'Token token="'
    })
  };


@Injectable({ providedIn: 'root' })
export class ArtistasService {





    constructor(private http: HttpClient) { }

    ListarArtistas(qt: number) :Observable<any>{
      
    return this.http.get(environment.apiConfiguracao +'/ListaTop/'+qt,{ headers: httpOptions.headers}
    ) .pipe(map((res: any) => {
        if( res.resultado){
          return  res.valor;
        }
        return null;
      }));    

    }
}