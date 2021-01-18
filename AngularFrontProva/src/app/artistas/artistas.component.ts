import { Component, OnInit } from '@angular/core';
import { Artista } from 'app/_models/artista';
import { ArtistasService } from 'app/_services/artistas.service';

@Component({
  selector: 'app-artistas',
  templateUrl: './artistas.component.html',
  styleUrls: ['./artistas.component.css']
})
export class ArtistasComponent implements OnInit {
  listaArtistas: Artista[];

  qtd: number = 10;
  constructor(private artistaService: ArtistasService) {
  }
  

  buscar(){

    this.artistaService.ListarArtistas(this.qtd)
    .subscribe(
      (dados)=>{
        this.listaArtistas = dados;

      }
    )

  }
  ngOnInit(): void {
    

    this.listaArtistas = new Array<Artista>();

    

  }

}

