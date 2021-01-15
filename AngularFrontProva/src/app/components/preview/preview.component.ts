import { Component, OnInit } from '@angular/core';
import { ImagemOfertas } from 'app/_models/imagensOferta';
import { Lojas } from 'app/_models/lojas';
import { LojaService } from 'app/_services/lojas.service';

@Component({
  selector: 'app-preview',
  templateUrl: './preview.component.html'
})



export class PreviewComponent implements OnInit{
  listaImagens: ImagemOfertas[];
  imagemOferta:ImagemOfertas;
  nomeLoja: string= "";
  semanaAtual: string= "";
  listaLojas: Lojas[];
  listaLojasDefault: Lojas[];


  constructor(private lojaService: LojaService) {
  }
  
  ngOnInit(): void {
    

    this.listaLojas = new Array<Lojas>();

    this.lojaService.ListaLojasPreview()
    .subscribe(
      (dados)=>{
        this.listaLojas = dados;

        this.semanaAtual = this.listaLojas[0].semana;
        this.listaLojasDefault = dados;        
        this.listaLojas.sort((one, two) => (one.nome > two.nome ? -1 : 1));

        this.carregarImagens();
      }
    )



  }


  semanaSelecionada(semana){

   
    this.listaLojas.forEach(element => {

      element.semana =this.semanaAtual;
    });
   

    if(semana == 'p'){


      
      this.listaLojas.forEach(element => {

        let diasemana =parseInt(element.semana )+1;

        element.semana = ("0" + diasemana).slice(-2);
      });
    }
    this.carregarImagens();
  }

  carregarImagens(){




    this.listaImagens = Array<ImagemOfertas>();
    


    this.listaLojas .forEach(element => {
      


      let imagemOferta1= new ImagemOfertas();    
      imagemOferta1.Loja = element.estado;
      imagemOferta1.nome = element.nome;

      imagemOferta1.url= "https://hntimagens.blob.core.windows.net/imagens/assets/Imagem/2021/S"+element.semana+""+element.nome+ "1.png";
      this.listaImagens.push(imagemOferta1);

     
      let imagemOferta2= new ImagemOfertas();    
      imagemOferta2.Loja = element.estado;
      imagemOferta2.nome = element.nome;
      imagemOferta2.url= "https://hntimagens.blob.core.windows.net/imagens/assets/Imagem/2021/S"+element.semana+""+element.nome+ "2.png";
      this.listaImagens.push(imagemOferta2);

      let imagemOferta3= new ImagemOfertas();    
      imagemOferta3.Loja = element.estado;
      imagemOferta3.nome = element.nome;
      imagemOferta3.url= "https://hntimagens.blob.core.windows.net/imagens/assets/Imagem/2021/S"+element.semana+""+element.nome+ "3.png";
      this.listaImagens.push(imagemOferta3);
    });



    
  }



  selecionarLoja(valor){
    this.listaLojas = this.listaLojasDefault;

    if(valor != 'Todos'){

      this.listaLojas = this.listaLojas.filter(s=>s.nome == valor);
    }
    this.carregarImagens();
  }
}

